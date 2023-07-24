using System.Net;
using System.Net.Mail;

namespace cSharpAcademy_Phone_Book
{
    internal class Mail
    {
        internal static void SendMail(string sendMailTo, string subject, string body)
        {
            string email = "chasity.dickinson@ethereal.email";

            var smtpClient = new SmtpClient("smtp.ethereal.email")
            {
                Port = 587,
                Credentials = new NetworkCredential("chasity.dickinson@ethereal.email", "18eAtdEYB83mKP3j5n"),
                EnableSsl = true,
            };

            smtpClient.Send(email, sendMailTo, subject, body);
        }
    }
}
