using System;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace Clothing_Store.Utils
{
    public interface IEmailServices
    {
        void SendEmail(SendEmailType type, string to, string content = "");
    }

    public class EmailServices : IEmailServices
    {
        private readonly EmailConfiguration config;

        public EmailServices(EmailConfiguration _config)
        {
            config = _config;
        }

        public async void SendEmail(SendEmailType type, string to, string content = "")
        {
            // create message
            MimeMessage email = null;
            switch (type)
            {
                case SendEmailType.REGISTER_SUCCESS:
                    email = EmailRegisterSuccess(to, content);
                    break;
                case SendEmailType.FORGOT_PASSWORD:
                    email = EmailForgotPassword(to, content);
                    break;
                case SendEmailType.ORDER_SUCCESS:
                    break;
                default:
                    email = null;
                    break;
            };

            if (email != null)
            {
                // send email
                using var smtp = new SmtpClient();
                smtp.Connect(config.SmtpServer, config.Port, SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(config.Username, config.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
        }

        private MimeMessage EmailForgotPassword(string to, string url)
        {
            var content = "<h3>CoolMate xin chào bạn,</h3>" +
                "<div>Bạn vừa yêu cầu khôi phục mật khẩu, đây là email tự động được cung cấp cho bạn để khôi phục lại mật khẩu mới có thời hạn trong 10 phút. Vui lòng không cung cấp email này cho bất kỳ ai.</div>" +
                "<div><a href="+ url +">Link reset password</a></div>";

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(config.From));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = "COOLMATE - Yêu cầu khôi phục mật khẩu";
            email.Body = new TextPart(TextFormat.Html) { Text = content };

            return email;
        }

        private MimeMessage EmailRegisterSuccess(string to, string url)
        {
            var content = "<h3>CoolMate xin chào bạn,</h3>" +
                "<div>Chúc mừng bạn đã đăng ký tài khoản thành công trên hệ thống website CoolMate. Giờ đây, bạn có thể thoả thích mua sắp ngay tại nhà.</div>" +
                "<div>Trân trọng</div>";

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(config.From));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = "COOLMATE - Tạo tài khoản thành công";
            email.Body = new TextPart(TextFormat.Html) { Text = content };

            return email;
        }
    }

    public enum SendEmailType {
        REGISTER_SUCCESS,
        FORGOT_PASSWORD,
        ORDER_SUCCESS
    }
}
