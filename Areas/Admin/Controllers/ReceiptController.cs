using Clothing_Store.Areas.Admin.Models;
using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReceiptController : BaseController
    {
        private readonly ApplicationDBContext _context;

        public ReceiptController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: /Admin/Receipt
        public IActionResult Index()
        {
            try
            {
                // Get all receipts
                List<AdminReceiptHistoryModel> receipts = _context.receipts
                    .Select(r => new AdminReceiptHistoryModel
                    {
                        ID = r.ID,
                        Fullname = r.Fullname,
                        Phone = r.Phone,
                        OrderAt = r.OrderAt,
                        DeliveryAt = r.DeliveryAt,
                        Method = r.Method,
                        TotalPay = r.TotalPay,
                        Status = r.Status
                    }).ToList();

                return View(new AdminReceiptHistoryViewModel() { history = receipts, currentUsername = GetCurrentUserName() });
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception", new { area = "" });
            }
        }

        // GET: /Admin/Receipt/Details/:id
        public IActionResult Details (int id)
        {
            try
            {
                // Get receipt info
                AdminReceiptDetailModel receipt = _context.receipts
                    .Where(r => r.ID == id)
                    .Select(r => new AdminReceiptDetailModel
                    {
                        ID = r.ID,
                        Fullname = r.Fullname,
                        Address = r.Address,
                        Method = r.Method,
                        CardNumber = r.CardNumber,
                        Status = r.Status,
                        OrderAt = r.OrderAt,
                        DeliveryAt = r.DeliveryAt,
                        Notes = r.Notes,
                        TotalPrice = r.TotalPrice,
                        TotalDiscount = r.TotalDiscount,
                        ShippingCost = r.ShippingCost,
                        TotalPay = r.TotalPay
                    }).FirstOrDefault();

                // Get receipt details (products)
                List<ReceiptDetail> details = _context.receiptDetails
                    .Where(rd => rd.ReceiptID == id)
                    .Select(rd => new ReceiptDetail
                    {
                        product = rd.product,
                        Color = rd.Color,
                        Size = rd.Size,
                        Quantity = rd.Quantity,
                        TotalPrice = rd.TotalPrice
                    }).ToList();

                if (receipt == null)
                {
                    return RedirectToAction("Index");
                }

                AdminReceiptDetailViewModel vm = new AdminReceiptDetailViewModel()
                {
                    details = details,
                    receipt = receipt,
                    currentUsername = GetCurrentUserName()
                };

                return View(vm);
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception", new { area = "" });
            }
        }

        // POST: /Admin/Receipt/UpadteStatus/:id
        [HttpPost]
        public IActionResult UpadteStatus(IFormCollection form, int id)
        {
            try
            {
                var status = form["status"];

                Receipt receipt = _context.receipts
                    .Where(rc => rc.ID == id)
                    .FirstOrDefault();

                // if oreder status = success then Delivery = Datetime Now
                if (status == OrderStatus.SUCCESS)
                {
                    receipt.Status = status;
                    receipt.DeliveryAt = DateTime.Now;
                }  else
                {
                    receipt.Status = status;
                    receipt.DeliveryAt = new DateTime();
                }
                _context.SaveChanges();

                return RedirectToAction("Details", "Receipt", new { id = id });
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception", new { area = "" });
            }
        }
    }
}
