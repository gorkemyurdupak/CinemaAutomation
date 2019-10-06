using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using Project.MVCUI.Models.MyTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            //ci.SeansVakit = new Seans().SeansTime;
            ci.EmptyControl = s.IsEmpty;
            ci.ChairID = s.SeatID;
            ci.Price = eklenecekUcret.TicketPrice;
            ci.TicketGenre = eklenecekUcret.TicketGenre;
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
        
        public ActionResult ChooseSeat()
        {   
            return View();
        }

        public ActionResult SiparisiOnayla()
        {
            if (Session["member"] != null)
            {
                AppUser mevcutKullanici = Session["member"] as AppUser;

                return View(Tuple.Create(new Ticket(), new PaymentVM()));
            }

            TempData["message"] = "Üye olmadan/Giriş yapmadan bilet alamazsınız ";

            return RedirectToAction("Index","Member");
        }
        [HttpPost]
        public ActionResult SiparisiOnayla([Bind(Prefix = "Item1")] Ticket item, [Bind(Prefix = "Item2")] PaymentVM item2)
        {
            //Burada artık bir client olarak Api'a istek göndermemiz lazım(Api consume)..Bunun icin WebApiClient package'ini Nuget'tan indiriyoruz..

            //Bir Api consume etme sürecinde actıgımız degişkenleri veya nesneler veya sürecleri ram'de cok uzun süre tutmamalıyız.
            bool result;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44317/api/");

                var postTask = client.PostAsJsonAsync("Payment/ReceivePayment", item2);
                //Burada item2 nesnesini Json olarak gönderiyoruz...Ve Base Adresimizin üzerine Payment/ReceivePayment'i ekliyoruz..
                var sonuc = postTask.Result;

                if (sonuc.IsSuccessStatusCode)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            if (result)
            {
                AppUser kullanici = Session["member"] as AppUser;
                item.TicketID = kullanici.UserID; //Order'in kim tarafından sipariş edildigini belirliyoruz.
                tickp.Add(item); //save edildiginde Order nesnesinin ID'si olusacak..
                int sonSiparisID = item.TicketID;
                Cart sepet = Session["scart"] as Cart;

                foreach (CartItem urun in sepet.Sepetim)
                {
                    Ticket t = new Ticket();
                    t.TicketID = sonSiparisID;
                    t.Movie.MovieID = urun.ID;
                    t.TicketPrice = urun.SubTotal;
                    t.TicketCount = urun.Amount;
                    tickp.Add(t);

                }
                TempData["odeme"] = "Siparişiniz bize ulasmıstır..Teşekkür ederiz";
                return RedirectToAction("Index","Member");

            }
            else
            {
                TempData["odeme"] = "Ödeme ile ilgili bir sıkıntı oluştu.Lütfen banka ile iletişime geciniz";
                return RedirectToAction("Index","Member");
            }
        }
        public ActionResult BuyTicket()
        {
            Ticket t = new Ticket();
            return View(Tuple.Create(movp.SelectActives(), tickp.SelectActives()));
        }
    }
}