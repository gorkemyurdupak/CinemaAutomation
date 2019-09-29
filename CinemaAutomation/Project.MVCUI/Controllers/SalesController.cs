using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.MODEL.Entities;
using Project.MVCUI.Models.MyTools;
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
        public ActionResult AddToCart(int id)
        {
            if (Session["member"] == null)
            {
                TempData["uyeDegil"] = "Lütfen bilet almadan önce üye olun!";
                Movie bekleyenFilm = movp.GetByID(id);
                Session["bekleyenUrun"] = bekleyenFilm;
                return RedirectToAction("Register", "Home");
            }

            Cart c = Session["scart"] == null ? new Cart() : Session["scart"] as Cart;

            Movie eklenecekFilm = movp.GetByID(id);
            Ticket eklenecekUcret = new Ticket();
            Seat s = new Seat();
            

            CartItem ci = new CartItem();
            ci.ID = eklenecekFilm.MovieID;
            ci.Name = eklenecekFilm.MovieName;
            ci.Price = eklenecekUcret.TicketPrice;
            ci.ImagePath = eklenecekFilm.ImagePath;
            ci.Date = new Seans().SeansTime;
            ci.EmptyControl = s.IsEmpty;
            ci.ChairID = s.SeatID;
            ci.Price = eklenecekUcret.TicketPrice;
            //ci.TicketType = eklenecekUcret.TicketSalesType;
            c.SepeteEkle(ci);

            Session["scart"] = c;
            return RedirectToAction("TicketPage");

        }
        public ActionResult TicketPage()
        {
            if (Session["scart"] != null)
            {
                Cart c = Session["scart"] as Cart;
                return View(c);
            }
            else if (Session["member"] == null)
            {
                TempData["uyeDegil"] = "Lütfen önce üye olun";
                return RedirectToAction("Register","Home");
            }
            TempData["message"] = "Sepetinizde ürün bulunmamaktadır";
            return RedirectToAction("Index","Member");
        }
        public ActionResult BuyTicket()
        { 
            Ticket t = new Ticket(); 
            return View(Tuple.Create(movp.SelectActives(), tickp.SelectActives()));
        }
        public ActionResult ChooseSeat()
        {   
            return View("ChooseSeat");
        }
    }
}