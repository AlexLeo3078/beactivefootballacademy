﻿using Microsoft.AspNetCore.Mvc;

namespace beactivefootballacademy.Controllers
{
	public class TeamController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
