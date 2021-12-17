using Clothing_Store.Areas.Admin.Models;
using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Clothing_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : BaseController
    {
        private readonly ApplicationDBContext _context;
        private readonly string SESSION_ADMIN_ID = "admin_id";
        private readonly string SESSION_USER_NAME = "user_name";

        public AccountController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {

                List<AdminAccountModel> accountsInfo = _context.accounts
                    .Where(ac => ac.IsDelete == false)
                    .Include(ac => ac.customer)
                    .Select(ac => new AdminAccountModel() { 
                        ID = ac.ID,
                        UserName = ac.Username,
                        Fullname = ac.customer.Fullname,
                        Email = ac.Email,
                        Phone = ac.customer.Phone,
                        CardNumber = ac.customer.CardNumber,
                        ValiDate = ac.customer.ValidDate
                    }).ToList();

                foreach(AdminAccountModel a in accountsInfo)
                {
                    var rc = _context.receipts
                        .Where(rc => rc.accountID == a.ID)
                        .GroupBy(rc => rc.accountID)
                        .Select(rc => new
                        {
                            TotalPay = rc.Sum(rc => rc.TotalPay),
                            TotalOrder = rc.Count()
                        }).FirstOrDefault();

                    if (rc != null)
                    {
                        a.TotalOrder = rc.TotalOrder;
                        a.TotalPayment = rc.TotalPay;
                    } else
                    {
                        a.TotalOrder = 0;
                        a.TotalPayment = 0;
                    }
                }

                AdminAccountViewModel vm = new AdminAccountViewModel()
                {
                    accounts = accountsInfo,
                    currentUsername = GetCurrentUserName()
                };

                return View(vm);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel account)
        {

            try
            {
                var isAdmin = _context.admins
                    .Include(ad => ad.account)
                    .Where(ad => ad.account.IsDelete == false)
                    .Where(ad => ad.account.Username == account.Username)
                    .FirstOrDefault();

                if (isAdmin != null)
                {
                    bool isMatch = BCrypt.Net.BCrypt.Verify(account.Password, isAdmin.account.Password);
                    if (isMatch)
                    {
                        HttpContext.Session.SetInt32(SESSION_ADMIN_ID, isAdmin.ID);
                        HttpContext.Session.SetString(SESSION_USER_NAME, account.Username);

                        return RedirectToAction("Index", "Receipt");
                    }

                }

                TempData["adminLoginErr"] = "Tên tài khoản hoặc mật khẩu không đúng";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int id)
        {
            try
            {
                AdminAccountDetailsViewModel account = _context.accounts
                    .Where(ac => ac.ID == id)
                    .Include(ac => ac.customer)
                    .Select(ac => new AdminAccountDetailsViewModel()
                    {
                        ID = ac.ID,
                        UserName = ac.Username,
                        Password = ac.Password,
                        Fullname = ac.customer.Fullname,
                        Email = ac.Email,
                        Phone = ac.customer.Phone,
                        Address = ac.customer.Address,
                        CardNumber = ac.customer.CardNumber,
                        ValiDate = ac.customer.ValidDate,
                        SecretNumber = ac.customer.SecretNumber
                    }).FirstOrDefault();

                    var rc = _context.receipts
                        .Where(rc => rc.accountID == id)
                        .GroupBy(rc => rc.accountID)
                        .Select(rc => new
                        {
                            TotalPay = rc.Sum(rc => rc.TotalPay),
                            TotalOrder = rc.Count()
                        }).FirstOrDefault();

                    if (rc != null)
                    {
                        account.TotalOrder = rc.TotalOrder;
                        account.TotalPayment = rc.TotalPay;
                    }
                    else
                    {
                        account.TotalOrder = 0;
                        account.TotalPayment = 0;
                    }

                    List<AdminReceiptHistoryModel> receipts = _context.receipts
                        .Where(r => r.accountID == id)
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

                account.Recepits = receipts;
                account.currentUsername = GetCurrentUserName();

                return View(account);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        public IActionResult Create()
        {
            try
            {
                ViewBag.acCreateSuccess = TempData["acCreateSuccess"];
                return View(new CreateModel() { currentUsername = GetCurrentUserName() });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Username, Password, Fullname, Email, Phone, Address, CardNumber, ValidDate, SecretNumber")] CreateModel account)
        {
            try
            {
                var isAccountExist = _context.accounts
                    .Where(ac => ac.Email == account.Email || ac.Username == account.Username)
                    .FirstOrDefault();

                if (isAccountExist != null)
                {
                    ViewBag.acCreateError = "Tên tài khoản hoặc email đã được đăng ký bởi người dùng khác";

                    return View(new CreateModel() { currentUsername = GetCurrentUserName() });
                }

                if (account.CardNumber != null
                    || account.SecretNumber != null
                    || account.ValidDate != null)
                {
                    BigInteger x1 = -1;
                    int x2 = -1;
                    if (!BigInteger.TryParse(account.CardNumber, out x1) || !Int32.TryParse(account.SecretNumber, out x2))
                    {
                        ViewBag.acCreateError = "Thông tin thẻ tín dụng không hợp lệ";

                        return View(new CreateModel() { currentUsername = GetCurrentUserName() });
                    }

                    if (!account.ValidDate.HasValue || account.ValidDate < DateTime.Now)
                    {
                        ViewBag.acCreateError = "Thẻ đã hết hạn hoặc không tồn tại";

                        return View(new CreateModel() { currentUsername = GetCurrentUserName() });
                    }
                }

                Account newAccount = new Account()
                {
                    Username = account.Username,
                    Password = BCrypt.Net.BCrypt.HashPassword(account.Password),
                    Email = account.Email
                };
                _context.accounts.Add(newAccount);
                _context.SaveChanges();

                int accountID = newAccount.ID;

                Customer newCustomer = new Customer()
                {
                    Fullname = account.Fullname,
                    Phone = account.Phone,
                    Address = account.Address,
                    AccountID = accountID
                };

                if (account.CardNumber != null && account.SecretNumber != null && account.ValidDate != null)
                {
                    newCustomer.CardNumber = account.CardNumber;
                    newCustomer.SecretNumber = account.SecretNumber;
                    newCustomer.ValidDate = (DateTime)account.ValidDate;
                }

                _context.customers.Add(newCustomer);
                _context.SaveChanges();

                return RedirectToAction("Details", new { id = newAccount.ID });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


        public IActionResult Update(int id)
        {
            try
            {
                int _id = id;
                AdminAccountDetailsViewModel account = _context.accounts
                    .Where(ac => ac.ID == id)
                    .Include(ac => ac.customer)
                    .Select(ac => new AdminAccountDetailsViewModel()
                    {
                        ID = ac.ID,
                        UserName = ac.Username,
                        Password = ac.Password,
                        Fullname = ac.customer.Fullname,
                        Email = ac.Email,
                        Phone = ac.customer.Phone,
                        Address = ac.customer.Address,
                        CardNumber = ac.customer.CardNumber,
                        ValiDate = ac.customer.ValidDate,
                        SecretNumber = ac.customer.SecretNumber
                    }).FirstOrDefault();

                var rc = _context.receipts
                    .Where(rc => rc.accountID == id)
                    .GroupBy(rc => rc.accountID)
                    .Select(rc => new
                    {
                        TotalPay = rc.Sum(rc => rc.TotalPay),
                        TotalOrder = rc.Count()
                    }).FirstOrDefault();

                if (rc != null)
                {
                    account.TotalOrder = rc.TotalOrder;
                    account.TotalPayment = rc.TotalPay;
                }
                else
                {
                    account.TotalOrder = 0;
                    account.TotalPayment = 0;
                }

                AdminUpdateAcccountViewModel accountDetails = new AdminUpdateAcccountViewModel();
                accountDetails.details = account;
                accountDetails.currentUsername = GetCurrentUserName();

                ViewBag.acUpdateError = TempData["acUpdateError"];
                ViewBag.acUpdateSuccess = TempData["acUpdateSuccess"];

                return View(accountDetails);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(AdminUpdateAcccountViewModel account, int id)
        {
            try
            {
                var updateInfo = account.updateModel;

                var isEmailExist = _context.accounts
                    .Where(ac => ac.Email == updateInfo.Email)
                    .Where(ac => ac.ID != id)
                    .FirstOrDefault();

                if (isEmailExist != null)
                {
                    TempData["acUpdateError"] = "Email đã được đăng ký bởi người dùng khác";

                    return RedirectToAction("Update", "Account");
                }

                if (updateInfo.CardNumber != null
                    || updateInfo.SecretNumber != null
                    || updateInfo.ValidDate != null)
                {
                    BigInteger x1 = -1;
                    int x2 = -1;
                    if (!BigInteger.TryParse(updateInfo.CardNumber, out x1) || !Int32.TryParse(updateInfo.SecretNumber, out x2))
                    {
                        TempData["acUpdateError"] = "Thông tin thẻ tín dụng không hợp lệ";
                        return RedirectToAction("Update", "Account");
                    }

                    if (!updateInfo.ValidDate.HasValue || updateInfo.ValidDate < DateTime.Now)
                    {
                        TempData["acUpdateError"] = "Thẻ đã hết hạn hoặc không tồn tại";
                        return RedirectToAction("Update", "Account");
                    }
                }

                var customer = _context.customers
                    .Where(c => c.AccountID == id)
                    .FirstOrDefault();

                if (customer != null)
                {
                    customer.Fullname = updateInfo.Fullname;
                    customer.Phone = updateInfo.Phone;
                    customer.Address = updateInfo.Address;

                    if (updateInfo.CardNumber != null && updateInfo.SecretNumber != null && updateInfo.ValidDate != null)
                    {
                        customer.CardNumber = updateInfo.CardNumber;
                        customer.ValidDate = (DateTime)updateInfo.ValidDate;
                        customer.SecretNumber = updateInfo.SecretNumber;
                    }

                    _context.customers.Update(customer);
                } else
                {
                    Customer newCustomer = new Customer()
                    {
                        Fullname = updateInfo.Fullname,
                        Phone = updateInfo.Phone,
                        Address = updateInfo.Address,
                        AccountID = id
                    };

                    if (updateInfo.CardNumber != null && updateInfo.SecretNumber != null && updateInfo.ValidDate != null)
                    {
                        newCustomer.CardNumber = updateInfo.CardNumber;
                        newCustomer.ValidDate = (DateTime)updateInfo.ValidDate;
                        newCustomer.SecretNumber = updateInfo.SecretNumber;
                    }

                    _context.customers.Add(newCustomer);
                    _context.SaveChanges();
                }
                _context.SaveChanges();

                return RedirectToAction("Details", new { id });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                var account = _context.accounts
                    .Where(ac => ac.ID == id)
                    .FirstOrDefault();

                account.IsDelete = true;
                _context.SaveChanges();

                return RedirectToAction("Index", "Account");
            } 
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }

}
