using beactivefootballacademy.Services;
using Microsoft.AspNetCore.Mvc;

namespace beactivefootballacademy.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View(ProductProviderService.GetProducts().Result);
		}
	}
}
