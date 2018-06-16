using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Emoh.Models;
using System.Net.Mail;
using System.Text;

namespace Emoh.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Guidance() => View();
        public IActionResult Download() => View();
        public IActionResult Links() => View();
        public IActionResult ContactMe() => View();
        [HttpPost]
        public IActionResult ContactMe(string name, string email, int subject, string body)
        {
            //return Content(name + email + subject + body);
            var mailMsg = new MailMessage();
            mailMsg.To.Add(new MailAddress("ehsan8020@gmail.com"));
            mailMsg.Subject = "پیامی از سایت ایمو";
            mailMsg.From = Emoh.Helpers.Email.Email.GetMailAddress(Helpers.Email.EmailType.Info);
            switch (subject)
            {
                case 1: mailMsg.Body = $"نام : {name}<hr>ایمیل : {email}<hr>موضوع : درخواست طراحی سایت<hr>پیام : {body}"; break;
                case 2: mailMsg.Body = $"نام : {name}<hr>ایمیل : {email}<hr>موضوع : درخواست کلاس خصوصی<hr>پیام : {body}"; break;
                case 3: mailMsg.Body = $"نام : {name}<hr>ایمیل : {email}<hr>موضوع : درخواست مشاوره برنامه نویسی<hr>پیام : {body}"; break;
                case 4: mailMsg.Body = $"نام : {name}<hr>ایمیل : {email}<hr>موضوع : سایر موارد<hr>پیام : {body}"; break;
                default: mailMsg.Body = $"نام : {name}<hr>ایمیل : {email}<hr>موضوع : ?!<hr>پیام : {body}"; break;
            }
            mailMsg.IsBodyHtml = true;
            var smtpobj = Emoh.Helpers.Email.Email.GetSmtp(Helpers.Email.EmailType.Info);
            try
            {
                smtpobj.Send(mailMsg);
                mailMsg.Dispose();
                ViewData["Result"] = true;
                return View();
            }
            catch (System.Exception ex)
            {
                mailMsg.Dispose();
                ViewData["Result"] = false;
                ViewData["ExceptionMessage"] = ex.Message;
                return View();
            }
        }
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
