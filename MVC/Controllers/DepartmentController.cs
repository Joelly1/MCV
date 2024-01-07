using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
			SampleEntities employee = new SampleEntities();
			var employees = employee.DepartmentLists.ToList();
			return View(employees);

        }
    }
}