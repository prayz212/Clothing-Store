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

        // GET: Cart
        public ActionResult Index()
        {
            //var isLoggedIn = HttpContext.Session.GetInt32(SESSION_USER_ID) != null;
            //if (!isLoggedIn)
            //{
            //    return RedirectToAction("Index", "Account");
            //}

            //int userID = (int)HttpContext.Session.GetInt32(SESSION_USER_ID);

            //var cartDetails = _context.cartDetails
            //    .Include(cd => cd.warehouse)
            //    .ThenInclude(w => w.product)
            //    .ThenInclude(p => p.promotion)
            //    .Include(cd => cd.warehouse)
            //    .ThenInclude(w => w.product)
            //    .ThenInclude(p => p.images)
            //    .Where(cd => cd.accountID == userID)
            //    .Where(cd => cd.Visible == true)
            //    .Select(cd => new CartProducts()
            //    {
            //        ID = cd.warehouse.product.ID,
            //        Name = cd.warehouse.product.Name,
            //        Quantity = cd.Quantity,
            //        Type = cd.warehouse.product.ProductType,
            //        Price = cd.warehouse.product.Price,
            //        image = cd.warehouse.product.images.Where(i => i.IsDelete == false).FirstOrDefault(),
            //        Promotion = (cd.warehouse.product.promotion == null || cd.warehouse.product.promotion.IsDelete)
            //                ? 0
            //                : cd.warehouse.product.promotion.Discount,
            //        Size = cd.warehouse.Size,
            //        Color = cd.warehouse.Color,
            //        WarehoustID = cd.warehouseID,
            //        IsSelected = cd.IsSelected
            //    }).ToList();

            //return View(cartDetails);



            return Ok(); //JUST FOR TEMP
        }

        // GET: Cart/Remove/5
        public ActionResult Remove(int warehouseID)
        {
            var isLoggedIn = HttpContext.Session.GetInt32(SESSION_USER_ID) != null;
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Account");
            }

            int userID = (int)HttpContext.Session.GetInt32(SESSION_USER_ID);

            //var cartD = _context.cartDetails
            //    .Where(cd => cd.warehouseID == warehouseID)
            //    .Where(cd => cd.accountID == userID)
            //    .FirstOrDefault();

            //if (cartD != null)
            //{
            //    cartD.Visible = false;
            //    cartD.Quantity = 0;
            //    cartD.IsSelected = false;
            //    _context.SaveChanges();
            //}
            //return RedirectToAction("Index", "Cart");

            return Ok(); //JUST FOR TEMP
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
                return BadRequest("Somethings went wrong ^^");
            }
        }

        // POST: Cart/Payment
        [HttpPost]
        public JsonResult Payment(IFormCollection form)
        {
            var data = form["items_select[]"];

            if (data.Count == 0)
            {
                return Json(new { status = "fail", mess = "need to select at least 1 product" });
            }

            var isLoggedIn = HttpContext.Session.GetInt32(SESSION_USER_ID) != null;
            if (!isLoggedIn)
            {
                return Json(new { status = "fail", mess = "need to login", url = "/Account/Index" });
            }

            int userID = (int)HttpContext.Session.GetInt32(SESSION_USER_ID);

            int warehouseID = 0;
            int quantity = 0;

            string[] warehousID_quantity;
            for (int i = 0; i < data.Count; i++)
            {
                warehousID_quantity = data[i].Split('-');
                Int32.TryParse(warehousID_quantity[0], out warehouseID);
                Int32.TryParse(warehousID_quantity[1], out quantity);

                var wh = _context.warehouses
                    .Where(w => w.ID == warehouseID)
                    .Select(w => new
                    {
                        Name = w.product.Name,
                        Color = w.Color,
                        Size = w.Size,
                        Quantity = w.Quantity
                    })
                    .FirstOrDefault();

                if (wh.Quantity < quantity)
                {
                    return Json(new { status = "fail", name = wh.Name, quantity = wh.Quantity, color = wh.Color, size = wh.Size });
                }

            }
            
            //for (int i = 0; i < data.Count; i++)
            //{
            //    warehousID_quantity = data[i].Split('-');
            //    Int32.TryParse(warehousID_quantity[0], out warehouseID);
            //    Int32.TryParse(warehousID_quantity[1], out quantity);

            //    var cartD = _context.cartDetails
            //        .Where(cd => cd.warehouseID == warehouseID)
            //        .Where(cd => cd.accountID == userID)
            //        .FirstOrDefault();

            //    if (cartD != null)
            //    {
            //        cartD.Quantity = quantity;
            //        cartD.IsSelected = true;
            //    }
            //}
            //_context.SaveChanges(); //

            return Json(new { status = "success", url = "/Cart/Payment" });
        }

        // POST: Cart/Add/7
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Add()
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


            var wh = _context.warehouses
                .Where(wh => wh.product.ID == productID)
                .Where(wh => wh.Size == size)
                .Where(wh => wh.Color == color)
                .FirstOrDefault();

            //var cd = _context.cartDetails
            //        .Where(cd => cd.accountID == userID)
            //        .Where(cd => cd.warehouseID == wh.ID)
            //        .FirstOrDefault();
            try
            {
                //if (cd != null)
                //{
                //    cd.Visible = true;
                //    cd.Quantity = cd.Quantity + quantity;
                //    _context.SaveChanges();
                //}
                //else
                //{

                //    CartDetails new_cd = new CartDetails()
                //    {
                //        accountID = userID,
                //        warehouseID = wh.ID,
                //        Quantity = quantity
                //    };

                //    _context.cartDetails.Add(new_cd);
                //    _context.SaveChanges();
                //}

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
                    if (info.CardNumber == null || info.ValidDate == null || info.SecretNumber == null)
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
                        ViewBag.PaymentInfoErrorMsg = "Vui lòng nhập đầy đủ thông tin về thẻ tín dụng";
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
                    Status = "Đang xử lý",
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
                        TotalPrice = c.product.promotion == null
                            ? c.product.Price * c.Quantity
                            : (int)Math.Round(c.product.Price - c.product.Price * (c.product.promotion.Discount/(float)100)) * c.Quantity
                    })
                    .ToList();

                _context.receiptDetails.AddRange(receiptDetails);
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
                return BadRequest("Opps!!! Somethings went wrongss ^^");
            }
        }

            private bool isLoggedIn()
        {
            return HttpContext.Session.GetInt32(SESSION_USER_ID) != null;
        }
    }
}
