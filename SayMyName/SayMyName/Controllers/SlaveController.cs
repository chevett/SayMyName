using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SayMyName.Models;

namespace SayMyName.Controllers
{
    public class SlaveController : Controller
    {
		[HttpPost]
		public ActionResult Register(SlaveViewModel viewModel)
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
