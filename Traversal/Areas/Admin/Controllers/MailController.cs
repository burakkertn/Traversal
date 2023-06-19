using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Traversal.Models;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest p)
        {
//----------------------------------------------------------------------------------------- Mail Gönderecek Bilgiler -------------------------------------------------------------------------------------------------------
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddress = new MailboxAddress ("Admin", "");
            mimeMessage.From.Add(mailboxAddress);
            mimeMessage.To.Add(mailboxAddress);
            //----------------------------------------------------------------------------------------- Mail Gönderecek Bilgiler -------------------------------------------------------------------------------------------------------


            //----------------------------------------------------------------------------------------- Mail Alacak Bilgiler -------------------------------------------------------------------------------------------------------
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", p.ReceiverMail);

            mimeMessage.To.Add(mailboxAddressTo);


            var bodyBuilder =  new BodyBuilder();
            bodyBuilder.TextBody = p.Body;

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = p.Konu;



            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("dostdigro@gmail.com", "tlzmlssykfxsflrv");
            client.Send(mimeMessage);
            client.Disconnect(true);

                return View();
        }
    }
}
