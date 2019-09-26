using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class SalesController : Controller
    {
        MovieRepository movp;
        TicketRepository tickp;
        public SalesController()
        {
            movp = new MovieRepository();
            tickp = new TicketRepository();
        }
        // GET: Sales
        public ActionResult BuyTicket()
        {
            Ticket t = new Ticket(); 
            return View();
        }
    }
}