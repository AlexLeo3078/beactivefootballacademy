using Microsoft.AspNetCore.Mvc;

namespace beactivefootballacademy.Controllers
{
	public class LogoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
