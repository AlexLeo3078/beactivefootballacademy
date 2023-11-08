using Microsoft.AspNetCore.Mvc;

namespace beactivefootballacademy.Controllers
{
	public class TAC : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
