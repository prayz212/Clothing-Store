﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.EntityFrameworkCore;

namespace Clothing_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _context;

        public HomeController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                var products = _context.Products
                    .Where(p => p.IsDelete == false)
                    .Where(p => p.Visible == true)
                    .Include(p => p.ratings)
                    .Include(p => p.images)
                    .Include(p => p.promotion)
                    .Select(p => new ProductViewModel()
                    {
                        ID = p.ID,
                        Name = p.Name,
                        Price = (p.promotion != null || !p.promotion.IsDelete)
                            ? (int)Math.Round((p.Price - (p.Price * (double)p.promotion.Discount / 100)) / 1000) * 1000
                            : p.Price,
                        ratings = (int)Math.Round(p.ratings.Where(r => r.IsDelete == false).Average(r => r.Star)),
                        image = p.images.Where(i => i.IsDelete == false).FirstOrDefault()
                    });

                return View(products);
            }
            catch
            {
                return Error();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NotFound()
        {
            return Ok("This is the message to announce you this page is not found, will adjust to the template not found later");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}