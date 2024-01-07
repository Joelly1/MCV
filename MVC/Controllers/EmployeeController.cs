using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
		public ActionResult Index(int departmentId)
		{

			SampleEntities employee = new SampleEntities();
			var employ = employee.EmployeeLists.Where(emp => emp.DepartmentId == departmentId).ToList();
			return View(employ);
		}
		public ActionResult Detail(int departmentId)
		{
			SampleEntities employee = new SampleEntities();
			var employ = employee.EmployeeLists.Where(emp=>emp.DepartmentId == departmentId).ToList();
			return View(employ);
		}
		public ActionResult Details()
        {
			Employee employee = new Employee()
			{
				EmployeeId = 101,
				Name = "John",
				Gender = "Male",
				City = "London"
			};
			return View(employee);
		}

		public ActionResult SecondDetails(int id)
		{
			
			SampleEntities employee = new SampleEntities();
			var employ = employee.EmployeeLists.Single(emp => emp.EmployeeId == id);
			return View(employ);
		}

	}
}