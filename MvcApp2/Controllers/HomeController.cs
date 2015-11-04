using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp2.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(string returnUrl)
		{
			//testtest
			ViewBag.ReturnUrl = returnUrl;
			return View();
		}
	}
}