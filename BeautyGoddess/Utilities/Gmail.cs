using System.Configuration;
using System.Net.Mail;

namespace BeautyGoddess.Utilities
{
    public class Gmail
    {
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string Host { get; set; }
        public static int Port { get; set; }
        public static bool Ssl { get; set; }
        public static string ToEmail { get; set; }
        public static bool IsHtml { get; set; }


        public string Subject { get; set; }
        public string Message { get; set; }

        static Gmail()
        {
            var gmailUserName = ConfigurationManager.AppSettings["gmailUserName"];
            var gmailPassword = ConfigurationManager.AppSettings["gmailPassword"];

            UserName = gmailUserName;
            ToEmail = gmailUserName;
            Password = gmailPassword;
            Host = "smtp.gmail.com";
            Port = 25;
            Ssl = true;
            IsHtml = true;
        }

        public void Send()
        {
            var smtp = new SmtpClient
            {
                Host = Host,
                Port = Port,
                EnableSsl = Ssl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(UserName, Password)
            };

            using (var message = new MailMessage(UserName, ToEmail))
            {
                message.Subject = Subject;
                message.Body = Message;
                message.IsBodyHtml = IsHtml;
                //smtp.Send(message);
            }
        }
    }
}