using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clothing_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private readonly string SESSION_ADMIN_ID = "admin_id";

        public IActionResult Index()
        {
            // if loggedin redirect to receipt
            if (HttpContext.Session.GetInt32(SESSION_ADMIN_ID) != null)
            {
                return RedirectToAction("Index", "Receipt");
            }

            ViewBag.adminLoginErr = TempData["adminLoginErr"];
            return View();
        }
    }
}
