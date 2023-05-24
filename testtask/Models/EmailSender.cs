using System.Net.Mail;
using System.Net;

namespace testtask.Models
{
    public class EmailSender: IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential("shima@gmail.com", "mvydsijnkgvwtwnp")
            };

            return client.SendMailAsync(
                new MailMessage(from: "shima@gmail.com",
                                to: email,
                                subject,
                                message
                                ));
        }
    }
}
