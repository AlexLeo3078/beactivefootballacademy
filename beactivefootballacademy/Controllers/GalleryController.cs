using Microsoft.AspNetCore.Mvc;
using beactivefootballacademy.Models;


namespace beactivefootballacademy.Controllers
{
	public class GalleryController : Controller
	{
		public GalleryModel model;

		public GalleryController()
		{
			model = new GalleryModel();

			var filePaths = Directory.GetFiles(System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\gallery")).ToList();

			foreach (var path in filePaths)
			{
				model.ImagePath.Add(Path.GetFileName(path));
			}

		}


		public IActionResult Index()
		{
			return View(model);
		}
	}
}
