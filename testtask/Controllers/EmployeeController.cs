using Microsoft.AspNetCore.Mvc;
using testtask.Models;

namespace testtask.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmailSender emailSender;

        public EmployeeController(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            await emailSender.SendEmailAsync("ahmad@gmail.com", "subject", "message");

            return View();
        }

        public IActionResult save()
        {
            // save
            return Content("success");
        }
    }
}
