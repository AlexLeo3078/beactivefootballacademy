using beactivefootballacademy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace beactivefootballacademy.Controllers
{
	public class ContactUsController : Controller
	{
		public IActionResult Index()
		{
			return View(new ContactUsModel());
		}

		[HttpPost]
		public IActionResult SendMessage(string emailAddress, string message, string name)
		{

			ContactUsModel model = new ContactUsModel
			{
				EmailAddress = emailAddress,
				Name = name,
				Message = message,
				ShowFeedBack = (string.Empty, "hidden")
			};

			try
			{
				MailAddress to = new MailAddress(emailAddress);
				MailAddress from = new MailAddress("alessandroleo@hotmail.co.uk");
				MailMessage mailMessage = new MailMessage(from, to);
				mailMessage.Subject = "be active football academy enquiries";
				mailMessage.Body = $"{message}";

				SmtpClient client = new SmtpClient("smtp.office365.com");
				client.Credentials =
					new System.Net.NetworkCredential("alessandroleo@hotmail.co.uk", "tI1GoVbjk2DfavL173RE","hotmail.co.uk");
				client.EnableSsl = true;
				client.Send(mailMessage);
			}

			catch (Exception ex)
			{
				model.ShowFeedBack = ("hidden", string.Empty);
			}

			return View("Index",model);
		}
	}
}
