using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository emp;
        AppUserRepository aprep;

        public EmployeeController()
        {
            emp = new EmployeeRepository();
            aprep = new AppUserRepository();
        }
        // GET: Admin/Employee
       public ActionResult ListEmployee()
        {
            return View(emp.SelectActives());
        }
    }
}