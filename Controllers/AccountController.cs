using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Clothing_Store.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly string SESSION_USER_ID = "user_id";
        private readonly string SESSION_USER_NAME = "user_name";

        public AccountController(ApplicationDBContext context)
        {
            _context = context;
        }
        // GET: Account
        public ActionResult Index()
        {
            var isLoggedIn = HttpContext.Session.GetString(SESSION_USER_ID) != null;
            if (isLoggedIn)
            {
                var t = HttpContext.Session.GetString(SESSION_USER_NAME);
                return Ok("DA DANG NHAP THANH CONG");
            }
            else
            {
                return View();
            }
        }

        // POST: Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(AccountViewModel account)
        {
            try
            {
                Account isExistEmail = _context.accounts
                    .Where(a => a.Email == account.register.Email)
                    .FirstOrDefault();

                Account isExistUsername = _context.accounts
                    .Where(a => a.Username == account.register.Username)
                    .FirstOrDefault();


                if (isExistEmail == null && isExistUsername == null)
                {
                    Account newAccount = new Account();
                    newAccount.Username = account.register.Username;
                    newAccount.Email = account.register.Email;

                    newAccount.Password = BCrypt.Net.BCrypt.HashPassword(account.register.Password);

                    _context.Add(newAccount);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.RegisterErrorMsg = "Tên tài khoản hoặc email đã tồn tại";
                    account.isError = true;
                    return View("Index", account);
                }
            }
            catch (Exception e)
            {
                ViewBag.RegisterErrorMsg = e.Message;
                account.isError = true;
                return View("Index", account);
            }
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountViewModel account)
        {
            try
            {
                Account isExist = _context.accounts
                    .Where(a => a.Username == account.login.Username).FirstOrDefault();

                if (isExist != null)
                {
                    bool isMatch = BCrypt.Net.BCrypt.Verify(account.login.Password, isExist.Password);
                    if (isMatch)
                    {
                        HttpContext.Session.SetInt32(SESSION_USER_ID, isExist.ID);
                        HttpContext.Session.SetString(SESSION_USER_NAME, isExist.Username);
                        return RedirectToAction("Index", "Cart");
                    }
                }
                
                ViewBag.LoginErrorMsg = "Tên tài khoản hoặc mật khẩu không đúng";
                account.isError = true;
                return View("Index", account);
            }
            catch (Exception e)
            {
                ViewBag.LoginErrorMsg = e.Message;
                account.isError = true;
                return View("Index", account);
            }
        }

        // GET: Account/Logout
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Index));
        }

        // POST: Account/Delete/5
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

    public class AccountViewModel
    {
        public RegisterModel register { get; set; }
        public LoginModel login { get; set; }

        public bool isError { get; set; }
    }

    public class RegisterModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên tài khoản phải có tối thiểu 4 ký tự")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có tối thiểu 8 ký tự")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [StringLength(255)]
        public string Email { get; set; }
    }

    public class LoginModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên tài khoản phải có tối thiểu 4 ký tự")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có tối thiểu 8 ký tự")]
        public string Password { get; set; }
    }
}
