using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clothing_Store.Controllers
{
    public class NotfoundController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Ok("This is the message to announce you this page is not found, will adjust to the template not found later");
        }
    }
}
