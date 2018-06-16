using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Emoh.Helpers.Email
{
    public enum EmailType { Empty, Info }

    public class Email
    {
        public static string GetMailName(EmailType type)
        {
            if (type == EmailType.Empty)
                return "";
            else
                return "info@emoh.ir";
        }

        public static MailAddress GetMailAddress(EmailType type)
        {
            if (type == EmailType.Empty)
                return new MailAddress("");
            else
                return new MailAddress("info@emoh.ir", "ایمو - سید احسان محمدی");
        }

        public static SmtpClient GetSmtp(EmailType type)
        {
            if (type == EmailType.Empty)
                return new SmtpClient();
            else
                return new SmtpClient
                {
                    Host = "mail.emoh.ir",
                    Credentials = new NetworkCredential("info@emoh.ir", "A5g#6Y4@*n!")
                };
        }
    }
}
