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

        public EmployeeController()
        {
            emp = new EmployeeRepository();

        }
        // GET: Admin/Employee
       public ActionResult ListEmployee()
        {
            return View(emp.SelectActives());
        }
        public ActionResult AddEmployee()
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee item)
        {
            emp.Add(item);
            return RedirectToAction("ListEmployee");
        }
        public ActionResult DeleteEmployee(int id)
        {
            emp.Delete(emp.GetByID(id));
            return RedirectToAction("ListEmployee");
        }
        
    }
}