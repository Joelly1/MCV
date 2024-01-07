using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CountryController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.CountriesList = new List<string>()
			{
				"Nigeria",
				"India",
				"US",
				"UK",
				"Canada"
			};
			return View();
		}
		public ViewResult About()
		{
			ViewData["Countries"] = new List<string>()
			{
				"Nigeria",
				"India",
				"US",
				"UK",
				"Canada"
			};
			return View();
		}
	}

}