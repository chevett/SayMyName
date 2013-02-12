using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SayMyName.Core;
using SayMyName.Models;
using StructureMap;

namespace SayMyName.Controllers
{
    public class SlaveController : Controller
    {
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult Register(SlaveViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				viewModel.IpAddress = IpAddress.Current();

				ObjectFactory.GetInstance<SlaveManager>().RegisterSlave(viewModel);
				return Redirect(viewModel.Location);
			}

			return View(viewModel);
		}

		[HttpGet]
		public ActionResult Snippet()
		{
			return View();
		}

    }
}
