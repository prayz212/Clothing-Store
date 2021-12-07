using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        
        // GET: Account/OrderHistory
        public ActionResult OrderHistory()
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
        // GET: Account/Order/5
        public ActionResult Order(string id)
        {
            return View();
        }

        // POST: Account/Delete/5
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
                int accId = (int) HttpContext.Session.GetInt32(SESSION_USER_ID);

                Customer customer = _context.customers
                    .Where(c => c.AccountID == accId)
                    .FirstOrDefault();

                AccountInfoModel info;
                if (customer != null)
                {
                    info = _context.accounts
                        .Where(a => a.ID == accId)
                        .Include(a => a.customer)
                        .Select(a => new AccountInfoModel()
                        {
                            Username = a.Username,
                            Fullname = a.customer.Fullname,
                            Email = a.Email,
                            Phone = a.customer.Phone,
                            Address = a.customer.Address,
                            CardNumber = a.customer.CardNumber,
                            ValidDate = a.customer.ValidDate,
                            SecretNumber = a.customer.SecretNumber
                        })
                        .FirstOrDefault();
                }
                else
                {
                    Account account = _context.accounts
                        .Where(a => a.ID == accId)
                        .FirstOrDefault();

                    info = new AccountInfoModel()
                    {
                        Username = account.Username,
                        Fullname = "",
                        Email = account.Email,
                        Phone = "",
                        Address = ""
                    };
                }

                return View(info);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        //  POST: Account/UpdateInfo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateInfo(AccountInfoModel account)
        {
            Customer customer;
            bool isInputCard = false;

            if (!isLoggedIn())
            {
                return RedirectToAction("Info");
            }

            if (account.CardNumber == null && account.ValidDate == null && account.SecretNumber == null)
            {
                customer = new Customer()
                {
                    Fullname = account.Fullname,
                    Phone = account.Phone,
                    Address = account.Address
                };
            }
            else if (account.CardNumber == null || account.ValidDate == null || account.SecretNumber == null)
            {
                AccountInfoModel accountInfo = new AccountInfoModel()
                {
                    Fullname = account.Fullname,
                    Phone = account.Phone,
                    Address = account.Address,
                    Email = account.Email
                };
                ViewBag.UpdateInfoErrorMsg = "Vui lòng nhập đầy đủ thông tin về thẻ tín dụng";
                return View(nameof(Info), accountInfo);
            }
            else
            {
                int x = -1;
                if (!Int32.TryParse(account.CardNumber, out x) || !Int32.TryParse(account.SecretNumber, out x))
                {
                    AccountInfoModel accountInfo = new AccountInfoModel()
                    {
                        Fullname = account.Fullname,
                        Phone = account.Phone,
                        Address = account.Address,
                        Email = account.Email
                    };
                    ViewBag.UpdateInfoErrorMsg = "Thông tin về thẻ tín dụng không hợp lệ";
                    return View(nameof(Info), accountInfo);
                }

                isInputCard = true;
                customer = new Customer()
                {
                    Fullname = account.Fullname,
                    Phone = account.Phone,
                    Address = account.Address,
                    CardNumber = account.CardNumber,
                    ValidDate = (DateTime)account.ValidDate,
                    SecretNumber = account.SecretNumber
                };

                if (customer.ValidDate < DateTime.Now)
                {
                    ViewBag.UpdateInfoErrorMsg = "Thời gian hết hạn phải lớn hơn thời gian hiện tại";
                    return View(nameof(Info), account);
                }
            }


            try
            {
                int id = (int)HttpContext.Session.GetInt32(SESSION_USER_ID);
                customer.AccountID = id;

                //Check customer is already exist or not
                var isExist = _context.customers
                    .Where(c => c.AccountID == id)
                    .FirstOrDefault();

                if (isExist != null) //If exist just update it
                {
                    if (!isInputCard)
                    {
                        isExist.Fullname = customer.Fullname;
                        isExist.Phone = customer.Phone;
                        isExist.Address = customer.Address;
                    }
                    else
                    {
                        isExist.Fullname = customer.Fullname;
                        isExist.Phone = customer.Phone;
                        isExist.Address = customer.Address;
                        isExist.CardNumber = customer.CardNumber;
                        isExist.ValidDate = (DateTime)customer.ValidDate;
                        isExist.SecretNumber = customer.SecretNumber;
                    }

                    _context.customers.Update(isExist);
                }
                else //Else if not exist add new it
                {
                    _context.customers.Add(customer);
                }

                _context.SaveChanges();
                ViewBag.UpdateInfoMsg = "Cập nhật thành công";
                return View(nameof(Info), account);
            }
            catch (Exception e)
            {
                ViewBag.UpdateInfoErrorMsg = e.Message;
                return View(nameof(Info), account);
            }
        }

        private bool isLoggedIn()
        {
            return HttpContext.Session.GetInt32(SESSION_USER_ID) != null;
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
}
