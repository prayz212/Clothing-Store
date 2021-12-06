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
            int userID = 5;

            var cartDetails = _context.cartDetails
                .Include(cd => cd.warehouse)
                .ThenInclude(w => w.product)
                .ThenInclude(p => p.promotion)
                .Include(cd => cd.warehouse)
                .ThenInclude(w => w.product)
                .ThenInclude(p => p.images)
                .Where(cd => cd.accountID == userID)
                .Where(cd => cd.Visible == true)
                .Select(cd => new CartProducts()
                {
                    ID = cd.warehouse.product.ID,
                    Name = cd.warehouse.product.Name,
                    Quantity = cd.Quantity,
                    Type = cd.warehouse.product.ProductType,
                    Price = cd.warehouse.product.Price,
                    image = cd.warehouse.product.images.Where(i => i.IsDelete == false).FirstOrDefault(),
                    Promotion = (cd.warehouse.product.promotion == null || cd.warehouse.product.promotion.IsDelete)
                            ? 0
                            : cd.warehouse.product.promotion.Discount,
                    Size = cd.warehouse.Size,
                    Color = cd.warehouse.Color,
                    WarehoustID = cd.warehouseID
                }).ToList();

            return View(cartDetails);
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

            var cartD = _context.cartDetails
                .Where(cd => cd.warehouseID == warehouseID)
                .Where(cd => cd.accountID == userID)
                .FirstOrDefault();

            if (cartD != null)
            {
                cartD.Visible = false;
                cartD.Quantity = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Cart");
        }

        // GET: Cart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }

        // POST: Cart/Add/7
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Add()
        {
            string color = Request.Form["color"];
            string size = Request.Form["size"];
            string Quantity = Request.Form["quantity"];
            string ProductID = Request.Form["productID"];
            int quantity = 1;
            Int32.TryParse(Quantity, out quantity);
            int productID = 0;
            Int32.TryParse(ProductID, out productID);

            int userID = 5;

            var wh = _context.warehouses
                .Where(wh => wh.product.ID == productID)
                .Where(wh => wh.Size == size)
                .Where(wh => wh.Color == color)
                .FirstOrDefault();

            var cd = _context.cartDetails
                    .Where(cd => cd.accountID == userID)
                    .Where(cd => cd.warehouseID == wh.ID)
                    .FirstOrDefault();

            if (cd != null)
            {
                cd.Visible = true;
                cd.Quantity = cd.Quantity + quantity;
                _context.SaveChanges();
            }
            else
            {

                CartDetails new_cd = new CartDetails()
                {
                    accountID = userID,
                    warehouseID = wh.ID,
                    Quantity = quantity
                };

                _context.cartDetails.Add(new_cd);
                _context.SaveChanges();
            }

            return Json("success");
        }

        // POST: Cart/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cart/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cart/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
