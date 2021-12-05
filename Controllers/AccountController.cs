using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Store.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDBContext _context;
        private IEmailServices _emailServices;
        private readonly string SESSION_USER_ID = "user_id";
        private readonly string SESSION_USER_NAME = "user_name";
        private readonly int EMAIL_EXPIRED_TIME = 30;

        public AccountController(ApplicationDBContext context, EmailConfiguration config)
        {
            _context = context;
            _emailServices = new EmailServices(config);
        }

        // GET: Account
        public ActionResult Index()
        {
            if (isLoggedIn())
            {
                return redirectAfterLogin();
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

                    return redirectAfterLogin(newAccount);
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
                        return redirectAfterLogin(isExist);
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

        //  GET: Account/ForgotPassword
        public ActionResult ForgotPassword()
        {
            return View();
        }

        //  POST: Account/ForgotPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ForgotPassword(ForgotPasswordModel model)
        {
            Account account = _context.accounts
                .Where(a => a.Email == model.Email)
                .FirstOrDefault();

            if (account == null)
            {
                ViewBag.ForgotPasswordErrorMsg = "Email không tồn tại/chưa đăng ký tài khoản";
            }
            else
            {
                //send url to the email

                RequestForgotPassword request = new RequestForgotPassword();
                request.Email = model.Email;
                request.ExpiredIn = DateTime.Now.AddMinutes(EMAIL_EXPIRED_TIME);

                try
                {
                    _context.requests.Add(request);
                    _context.SaveChanges();

                    var encode = Convert.ToBase64String(Encoding.UTF8.GetBytes(request.ID.ToString() + "_" + request.Email));

                    var baseUrl = Request.Scheme + "://" + Request.Host.Value;
                    var resetUrl = baseUrl + "/Account/" + nameof(ResetPassword) + "?requestId=" + encode;

                    _emailServices.SendEmail(SendEmailType.FORGOT_PASSWORD, request.Email, resetUrl);

                    ViewBag.ForgotPasswordMsg = "Link khôi phục mật khẩu đã được gửi qua Email vừa nhập";
                }
                catch(Exception e)
                {
                    ViewBag.ForgotPasswordErrorMsg = e.Message;
                }
            }

            
            return View("ForgotPassword");
        }

        //  GET: Account/ResetPassword
        public ActionResult ResetPassword([FromQuery(Name = "requestId")] string Id)
        {
            var decode = Encoding.UTF8.GetString(Convert.FromBase64String(Id));
            var data = decode.Split("_");

            try
            {
                var request = _context.requests
                    .Where(r => r.ID == Int32.Parse(data[0]))
                    .FirstOrDefault();

                if (DateTime.Compare(DateTime.Now, request.ExpiredIn) < 0)
                {
                    Account account = _context.accounts
                        .Where(a => a.Email == data[1]).FirstOrDefault();

                    ViewBag.AccountName = account.Username;
                    return View();
                }
                else
                {
                    return Ok("This link is expired");
                }
            }
            catch (Exception e)
            {
                ViewBag.ForgotPasswordErrorMsg = e.Message;
                return View(nameof(ForgotPassword));
            }
        }

        // POST: Account/ResetPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ResetPassword(ResetPasswordModel resetPassword)
        {
            try
            {
                Account isExist = _context.accounts
                    .Where(a => a.Username == resetPassword.Username).FirstOrDefault();

                if (isExist != null)
                {
                    isExist.Password = BCrypt.Net.BCrypt.HashPassword(resetPassword.Password);
                    _context.accounts.Update(isExist);
                    _context.SaveChanges();

                    return redirectAfterLogin(isExist);
                }
                else
                {
                    ViewBag.ForgotPasswordErrorMsg = "Đã xảy ra lỗi, vui lòng thao tác lại";
                    return View(nameof(ForgotPassword));
                }
            }
            catch (Exception e)
            {
                ViewBag.ForgotPasswordErrorMsg = e.Message;
                return View(nameof(ForgotPassword));
            }
        }

        //  GET: Account/Info
        public ActionResult Info()
        {
            if (isLoggedIn())
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        private bool isLoggedIn()
        {
            return HttpContext.Session.GetString(SESSION_USER_ID) != null;
        }

        private ActionResult redirectAfterLogin(Account account = null)
        {
            if (account != null)
            {
                HttpContext.Session.SetInt32(SESSION_USER_ID, account.ID);
                HttpContext.Session.SetString(SESSION_USER_NAME, account.Username);
            }
            return RedirectToAction("Info");
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
