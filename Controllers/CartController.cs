using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Clothing_Store.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly string SESSION_USER_ID = "user_id";
        private readonly int SHIPPING_COST = 25000;

        public CartController(ApplicationDBContext context)
        {
            _context = context;
        }

        // Get cart by account
        // GET: Cart
        public ActionResult Index()
        {
            try
            {
                // check logged in
                var isLoggedIn = HttpContext.Session.GetInt32(SESSION_USER_ID) != null;
                if (!isLoggedIn)
                {
                    return RedirectToAction("Index", "Account");
                }

                int userID = (int)HttpContext.Session.GetInt32(SESSION_USER_ID);

                // Get all products in cart by account  
                var cartDetails = _context.cartDetails
                    .Include(w => w.product)
                    .ThenInclude(p => p.promotion)
                    .Include(w => w.product)
                    .ThenInclude(p => p.images)
                    .Where(cd => cd.product.IsDelete == false && cd.product.Visible == true)
                    .Where(cd => cd.accountID == userID)
                    .Where(cd => cd.IsDelete == false)
                    .Where(cd => cd.Quantity > 0)
                    .Select(cd => new CartProducts()
                    {
                        ID = cd.ID,
                        Name = cd.product.Name,
                        Quantity = cd.Quantity,
                        Type = cd.product.ProductType,
                        Price = cd.product.Price,
                        image = cd.product.images.Where(i => i.IsDelete == false).FirstOrDefault(),
                        Promotion = (cd.product.promotion == null || cd.product.promotion.IsDelete || cd.product.promotion.To < DateTime.Now || cd.product.promotion.From > DateTime.Now)
                                ? 0
                                : cd.product.promotion.Discount,
                        Size = cd.Size,
                        Color = cd.Color,
                        ProductID = cd.productID,
                        IsSelected = cd.IsSelected
                    }).ToList();

                return View(cartDetails);

            } catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
            }
        }

        // Remove a product from cart
        // GET: Cart/Remove/5
        public ActionResult Remove(int cartDetailsID)
        {
            try
            {
                var isLoggedIn = HttpContext.Session.GetInt32(SESSION_USER_ID) != null;
                if (!isLoggedIn)
                {
                    return RedirectToAction("Index", "Account");
                }

                int userID = (int)HttpContext.Session.GetInt32(SESSION_USER_ID);

                // Find the product in cart
                var cartD = _context.cartDetails
                    .Where(cd => cd.ID == cartDetailsID)
                    .Where(cd => cd.accountID == userID)
                    .FirstOrDefault();

                // update the IsDelete and IsSelected value
                if (cartD != null)
                {
                    cartD.IsDelete = true;
                    cartD.IsSelected = false;
                    _context.SaveChanges();
                }
                return RedirectToAction("Index", "Cart");

            } catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
            }
        }

        // GET: Cart/Payment
        public ActionResult Payment()
        {
            if (!isLoggedIn())
            {
                return RedirectToAction("Index", "Account");
            }

            try
            {
                int accId = (int)HttpContext.Session.GetInt32(SESSION_USER_ID);

                var isExits = _context.customers
                    .Where(c => c.AccountID == accId)
                    .FirstOrDefault();

                var account = _context.accounts
                    .Where(a => a.ID == accId)
                    .FirstOrDefault();

                // Get customer info
                PaymentInfoModel customerInfo = new PaymentInfoModel();
                if (isExits != null)
                {
                    customerInfo.Fullname = isExits.Fullname;
                    customerInfo.Phone = isExits.Phone;
                    customerInfo.Email = account.Email;
                    customerInfo.Address = isExits.Address;
                    customerInfo.Note = "";
                    customerInfo.Method = "COD";
                    customerInfo.CardNumber = isExits.CardNumber == null ? "" : isExits.CardNumber;
                    customerInfo.ValidDate = isExits.ValidDate;
                    customerInfo.SecretNumber = isExits.SecretNumber == null ? "" : isExits.SecretNumber;
                }

                // Get the selected product in cart by account
                List<CartPaymentModel> selectedProducts = _context.cartDetails
                    .Where(cd => cd.accountID == accId)
                    .Where(cd => cd.IsSelected == true)
                    .Where(cd => cd.IsDelete == false)
                    .Include(cd => cd.product)
                    .ThenInclude(p => p.promotion)
                    .Select(cd => new CartPaymentModel
                    {
                        product = cd.product,
                        quantity = cd.Quantity,
                        promotion = cd.product.promotion == null || cd.product.promotion.IsDelete || cd.product.promotion.To < DateTime.Now || cd.product.promotion.From > DateTime.Now
                        ? null
                        : cd.product.promotion
                    })
                    .ToList();

                PaymentViewModel payment = new PaymentViewModel();
                payment.info = customerInfo;
                payment.carts = selectedProducts;

                return View(payment);
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
            }
        }

        // POST: Cart
        [HttpPost]
        public JsonResult Index(IFormCollection form)
        {
            try
            {
                var data = form["items_select[]"];

                // check if user choose at lease 1 product
                if (data.Count == 0)
                {
                    return Json(new { status = "fail", mess = "Cần chọn ít nhất 1 sản phẩm để thanh toán" });
                }

                var isLoggedIn = HttpContext.Session.GetInt32(SESSION_USER_ID) != null;
                if (!isLoggedIn)
                {
                    return Json(new { status = "fail", mess = "need to login", url = "/Account/Index" });
                }

                int userID = (int)HttpContext.Session.GetInt32(SESSION_USER_ID);

                var cartDetail = _context.cartDetails
                    .Where(cd => cd.accountID == userID);

                foreach (var c in cartDetail)
                {
                    c.IsSelected = false;
                }
                _context.SaveChanges();

                int cartDetailsID = 0;
                int quantity = 0;
                
                // Check quantity of product with size, color in warehouse
                string[] cartDetailsID_quantity;
                for (int i = 0; i < data.Count; i++)
                {
                    cartDetailsID_quantity = data[i].Split('-');
                    Int32.TryParse(cartDetailsID_quantity[0], out cartDetailsID);
                    Int32.TryParse(cartDetailsID_quantity[1], out quantity);

                    var cartD = _context.cartDetails
                        .Where(c => c.accountID == userID)
                        .Where(c => c.ID == cartDetailsID)
                        .Include(c => c.product)
                        .FirstOrDefault();

                    var wh = _context.warehouses
                        .Where(w => w.product.ID == cartD.productID)
                        .Where(w => w.Size == cartD.Size)
                        .Where(w => w.Color == cartD.Color)
                        .Select(w => new
                        {
                            Name = w.product.Name,
                            Color = w.Color,
                            Size = w.Size,
                            Quantity = w.Quantity
                        })
                        .FirstOrDefault();

                    if (wh == null)
                    {
                        return Json(new
                        {
                            status = "fail",
                            mess = "Sản phẩm: " + cartD.product.Name + ", màu: " + cartD.Color
                                    + ", size: " + cartD.Size + ", hiện đang không còn hàng"
                        });
                    }

                    if (wh.Quantity < quantity)
                    {
                        return Json(new
                        {
                            status = "fail",
                            mess = "Sản phẩm: " + wh.Name + ", màu: " + wh.Color
                                    + ", size: " + wh.Size + ", chỉ còn số lượng: " + wh.Quantity
                        });
                    }

                }
                
                for (int i = 0; i < data.Count; i++)
                {
                    cartDetailsID_quantity = data[i].Split('-');
                    Int32.TryParse(cartDetailsID_quantity[0], out cartDetailsID);
                    Int32.TryParse(cartDetailsID_quantity[1], out quantity);

                    var cd = _context.cartDetails
                        .Where(c => c.ID == cartDetailsID)
                        .FirstOrDefault();

                    if (cd != null)
                    {
                        cd.Quantity = quantity;
                        cd.IsSelected = true;
                    }
                }
                _context.SaveChanges();

                return Json(new { status = "success", url = "/Cart/Payment" });

            } catch (Exception e)
            {
                return Json(new { status = "fail", mess = "Đã xuất hiện lỗi, vui lòng thử lại sau" });
            }
        }

        // POST: Cart/Add/7
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Add()
        {
            try
            {
                var isLoggedIn = HttpContext.Session.GetInt32(SESSION_USER_ID) != null;

                if (!isLoggedIn)
                {
                    return Json(new { status = "fail", mess = "need to login", url = "/Account/Index" });
                }

                int userID = (int) HttpContext.Session.GetInt32(SESSION_USER_ID);

                string color = Request.Form["color"];
                string size = Request.Form["size"];
                string Quantity = Request.Form["quantity"];
                string ProductID = Request.Form["productID"];
                int quantity = 1;
                Int32.TryParse(Quantity, out quantity);
                int productID = 0;
                Int32.TryParse(ProductID, out productID);

                // Check if product in cart
                var isProducuInCart = _context.cartDetails
                    .Where(cd => cd.accountID == userID)
                    .Where(cd => cd.IsDelete == false)
                    .Where(cd => cd.productID == productID && cd.Color == color && cd.Size == size)
                    .FirstOrDefault();

                // if null then add, else then update the quantity
                if (isProducuInCart == null)
                {
                    CartDetails new_cd = new CartDetails()
                    {
                        accountID = userID,
                        productID = productID,
                        Color = color,
                        Size = size,
                        Quantity = quantity
                    };

                    _context.cartDetails.Add(new_cd);
                } else
                {
                    isProducuInCart.Quantity = isProducuInCart.Quantity + quantity;
                }

                _context.SaveChanges();

                return Json(new { status = "success" });
            }
            catch (Exception e)
            {
                return Json(new { status = "fail" });
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PaymentProcess(PaymentViewModel payment)
        {
            try
            {
                int accId = (int)HttpContext.Session.GetInt32(SESSION_USER_ID);
                PaymentInfoModel info = payment.info;

                //Check valid info if payment method is credit card
                if (info.Method == "CreditCard")
                {
                    List<CartPaymentModel> selectedProducts = _context.cartDetails
                        .Where(cd => cd.accountID == accId)
                        .Where(cd => cd.IsSelected == true)
                        .Where(cd => cd.IsDelete == false)
                        .Include(cd => cd.product)
                        .ThenInclude(p => p.promotion)
                        .Select(cd => new CartPaymentModel
                        {
                            product = cd.product,
                            quantity = cd.Quantity,
                            promotion = cd.product.promotion == null || cd.product.promotion.IsDelete || cd.product.promotion.To < DateTime.Now || cd.product.promotion.From > DateTime.Now
                            ? null
                            : cd.product.promotion
                        })
                        .ToList();

                    payment.carts = selectedProducts;

                    if (info.CardNumber == null || info.ValidDate == null || info.SecretNumber == null)
                    {
                        ViewBag.PaymentInfoErrorMsg = "Vui lòng nhập đầy đủ thông tin về thẻ tín dụng";
                        return View(nameof(Payment), payment);
                    }

                    if (info.ValidDate < DateTime.Now)
                    {
                        ViewBag.PaymentInfoErrorMsg = "Thời gian hết hạn phải lớn hơn thời gian hiện tại";
                        return View(nameof(Payment), payment);
                    }
                }

                //Insert data into database
                List<CartDetails> cartDetails = _context.cartDetails
                    .Where(cd => cd.accountID == accId)
                    .Where(cd => cd.IsSelected == true)
                    .Where(cd => cd.IsDelete == false)
                    .Include(cd => cd.product)
                    .ThenInclude(p => p.promotion)
                    .Select(cd => new CartDetails
                    {
                        ID = cd.ID,
                        productID = cd.product.ID,
                        accountID = accId,
                        Size = cd.Size,
                        Color = cd.Color,
                        Quantity = cd.Quantity,
                        product = cd.product,
                        IsSelected = cd.IsSelected
                    })
                    .ToList();

                int totalPrice = cartDetails.Sum(c => c.product.Price * c.Quantity);
                int totalDiscount = 0;
                if (cartDetails.Where(p => p.product.promotion != null).Count() > 0)
                {
                    var promotionProduct = cartDetails
                        .Where(cd => cd.product.promotion != null)
                        .Where(p => p.product.promotion.From <= DateTime.Now)
                        .Where(p => p.product.promotion.To >= DateTime.Now)
                        .ToList();
                                        
                    totalDiscount = (int)Math.Round(promotionProduct.Sum(p => (p.product.Price * (p.product.promotion.Discount / (float)100)) * p.Quantity));
                }
                int shippingCost = SHIPPING_COST;
                int totalPay = totalPrice - totalDiscount + shippingCost;

                //Create new receipt row data
                Receipt receipt = new Receipt()
                {
                    Fullname = info.Fullname,
                    Phone = info.Phone,
                    Email = info.Email,
                    Address = info.Address,
                    Notes = info.Note == null ? "" : info.Note,
                    TotalPrice = totalPrice,
                    TotalDiscount = totalDiscount,
                    ShippingCost = shippingCost,
                    TotalPay = totalPay,
                    Method = info.Method,
                    Status = OrderStatus.IN_PROCESS,
                    OrderAt = DateTime.Now,
                    accountID = accId
                };

                if (info.Method == "CreditCard")
                {
                    receipt.CardNumber = info.CardNumber;
                    receipt.ValidDate = (DateTime)info.ValidDate;
                    receipt.SecretNumber = info.SecretNumber;
                }

                _context.Add(receipt);
                _context.SaveChanges();

                int id = receipt.ID;

                //Create new receipt detail rows data
                List<ReceiptDetail> receiptDetails = cartDetails
                    .Select(c => new ReceiptDetail()
                    {
                        ProductID = c.product.ID,
                        ReceiptID = id,
                        Color = c.Color,
                        Size = c.Size,
                        Quantity = c.Quantity,
                        TotalPrice = c.product.promotion == null || c.product.promotion.From > DateTime.Now || c.product.promotion.To < DateTime.Now
                            ? c.product.Price * c.Quantity
                            : (int)Math.Round(c.product.Price - c.product.Price * (c.product.promotion.Discount/(float)100)) * c.Quantity
                    })
                    .ToList();

                _context.receiptDetails.AddRange(receiptDetails);
                _context.SaveChanges();

                //Update quantity in warehouse
                var productIDs = cartDetails.Select(cd => cd.productID).ToList();

                var warehouses = _context.warehouses
                    .Where(w => productIDs.Contains(w.product.ID))
                    .ToList();

                foreach(CartDetails c in cartDetails)
                {
                    var w = warehouses
                        .Where(w => w.product.ID == c.productID)
                        .Where(w => w.Size == c.Size)
                        .Where(w => w.Color == c.Color)
                        .FirstOrDefault();

                    w.Quantity = w.Quantity - c.Quantity;
                    w.Sold = w.Sold + c.Quantity;
                }
                _context.warehouses.UpdateRange(warehouses);
                _context.SaveChanges();


                //Delete payment product from cart
                cartDetails.ForEach(cd => cd.IsDelete = true);
                _context.cartDetails.UpdateRange(cartDetails);
                _context.SaveChanges();

                //Redirect to order history
                return RedirectToAction("OrderDetail", "Account", new { id });
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
            }
        }

        private bool isLoggedIn()
        {
            return HttpContext.Session.GetInt32(SESSION_USER_ID) != null;
        }
    }
}
