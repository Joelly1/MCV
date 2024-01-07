using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
	public class HomeController : Controller
	{
		public string Index(string id, string name)
		{
			//return "Id = " + id + "Name = " + Request.QueryString["name"];
			return "Id = " + id + "Name = " + name;
		}

	}
}