using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SayMyName.Models;

namespace SayMyName.Controllers
{
    public class ClientsController : Controller
    {

		private const string LocationFilePathAndName = @"C:\Users\Public\SayMyName.txt";

		private string ReadUrl()
		{
			try
			{
				var str = System.IO.File.ReadAllText(LocationFilePathAndName);
			}
			catch (System.IO.FileNotFoundException)
			{ }

			return string.Empty;
		}

		private void WriteUrl(string location)
		{
			System.IO.File.WriteAllText(LocationFilePathAndName, location);

		}

		[HttpPost]
		public ActionResult Register(RegistrationViewModel viewModel)
		{
			return View(viewModel);
		}

		[HttpGet]
		public ActionResult Snippet()
		{
			return View();
		}

    }
}
