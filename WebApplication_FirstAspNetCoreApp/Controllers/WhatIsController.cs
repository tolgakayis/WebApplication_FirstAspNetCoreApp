using Microsoft.AspNetCore.Mvc;
using WebApplication_FirstAspNetCoreApp.Models;

namespace WebApplication_FirstAspNetCoreApp.Controllers
{
    public class WhatIsController : Controller
    {
        public IActionResult RazorSyntax()
        {
            return View();
        }
		public IActionResult HtmlHelpers()
		{
            Student student = new Student { FirstName="Tolga" };

			return View(student);
		}
	}
}
