using Microsoft.AspNetCore.Mvc;
using WebApplication_FirstAspNetCoreApp.Models;

namespace WebApplication_FirstAspNetCoreApp.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Details()
		{
			Student student = new Student
			{
				FirstName = "John",
				LastName = "Smith",
				Age = 22,
				Password = "12345",
				YeniKayitMi = true
			};

			return View(student);
		}
	}
}
