using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace FTL.Controllers
{
    using System.Net.Mail;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Support()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Support(FormCollection fc)
        {
            //send email to info@patientsafetymovement.org
            //SendGridAPI KEY:  moved to secure storage.
            string apiKey = "NOSOUPFORYOU";
            dynamic sg = new SendGridAPIClient(apiKey);
            Email from = new Email("patientaider@ftltech.org", "PatientAider Feedback Engine");
            string subject = fc["Subject"];
            Email to = new Email("info@patientsafetymovement.org");
            string message = "The following PatientAider feedback message has been received.  "
                             + $"This feedback was sent by {fc["Name"]} with email address {fc["EMail"]} "
                             + $"at {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}:"
                             + Environment.NewLine + Environment.NewLine
                             + $"{fc["Subject"]}" + Environment.NewLine + $"{fc["YourMessage"]}";
            Content content = new Content("text/plain", message);
            Mail mail = new Mail(from, subject, to, content);

            dynamic response = await sg.client.mail.send.post(requestBody: mail.Get());
            return View("Index");
        }
    }
}