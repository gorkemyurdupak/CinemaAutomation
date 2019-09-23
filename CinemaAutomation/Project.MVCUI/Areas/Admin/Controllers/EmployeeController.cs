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
            if (Session["SuperAdmin"]!=null)
            {
                return View(emp.SelectActives());
            }
            return RedirectToAction("Movie","MovieList");
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
        public ActionResult UpdateEmployee(int id)
        {
            return View(emp.GetByID(id));
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee item)
        {

            emp.Update(item);
            return RedirectToAction("ListEmployee");
        }
        public ActionResult Inbox()
        {
            if (Session["SuperAdmin"]!=null)
            {
                return View();
            }
            return RedirectToAction("Member","Index");
        }
    }
}