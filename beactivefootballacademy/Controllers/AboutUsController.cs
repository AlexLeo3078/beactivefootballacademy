using Microsoft.AspNetCore.Mvc;

namespace beactivefootballacademy.Controllers
{
	public class AboutUsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
