using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clothing_Store.Controllers
{
    public class ExceptionController : Controller
    {
        // 404 Not found
        public IActionResult Notfound()
        {
            return View("Notfound");
        }

        // 500 Error
        public IActionResult Error()
        {
            return View();
        }
    }
}
