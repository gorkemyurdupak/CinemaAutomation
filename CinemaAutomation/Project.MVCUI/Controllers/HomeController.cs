using Project.COMMON.Tools;
using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.COMMON.Tools;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.DAL.Context;
using Project.BLL.SingletonPattern;
using System.Web.Security;

namespace Project.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        AppUserRepository aprep;
        AppUserProfileRepository apdrep;
        public HomeController()
        {
            aprep = new AppUserRepository();
            apdrep = new AppUserProfileRepository();
            
        }
        // GET: Home
        public ActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Register([Bind(Prefix = "Item1")]AppUser item, [Bind(Prefix = "Item2")]AppUserProfile item2)
        {
            if (aprep.Any(x => x.UserName == item.UserName))
            {
                ViewBag.ZatenVar = "Lütfen başka bir kullanıcı adı giriniz";
                return View();
            }
            else if (aprep.Any(x => x.Email == item.Email))
            {
                ViewBag.ZatenVar = "Bu Email daha önceden alınmış";
            }
            //Kullanıcı basarılı bir şekilde register işlemini tamamlıyorsa ona mail gönder...

            string gonderilecekMail = "Tebrikler hesabınız oluşturuldu. Hesabınızı aktive etmek için https://localhost:44317/Home/Activation/" + item.ActivationCode + " linkine tıklayabilirsiniz.";  //MVCUI'a sağ tık,Properties den girdiğinde web kısmında url'i göreceksin. (Aktivasyon action'ı açılmak zorunda unutma!)

            MailSender.Send(item.Email, password: "Sinema123", body: gonderilecekMail, subject: "Hesap Aktivasyonu!"); //Password ??

            aprep.Add(item); // buradan sonra item'in id'si olusmus oluyor...O yüzden item2'nin id'sini verecek isek buradan sonra vermeliyiz.

            item2.ID = item.UserID;

            apdrep.Add(item2);

            return View("RegisterOk");
        }

        public ActionResult Activation(Guid id)
        {
            if (aprep.Any(x => x.ActivationCode == id))
            {
                AppUser aktiveEdilecek = aprep.Default(x => x.ActivationCode == id);
                aktiveEdilecek.IsActive = true;
                aprep.Update(aktiveEdilecek);

                TempData["HesapAktif"] = "Hesabınız aktif hale getirildi.";
                Session["member"] = aktiveEdilecek;

                return RedirectToAction("Index", "Member");
            }
            TempData["HesapAktif"] = "Aktif edilecek hesap bulunamadı";
            return RedirectToAction("Register");
        }

        public ActionResult RegisterOk()
        {
            return View();
        }

        public ActionResult Login()
        {
            AppUser newUser = CheckCookie();
            if (newUser == null) return View();

            else return View(newUser);
            
        }

        [HttpPost]
        public ActionResult Login(AppUser item,string Hatirla)
        {
            if (Hatirla == "true")
            {
                //Eger hatirlanma secenegi işaretli ise Cookiee burada yaratılır.
                HttpCookie girisIsim = new HttpCookie("userName");
                girisIsim.Expires = DateTime.Now.AddMinutes(5);
                girisIsim.Value = item.UserName;
                Response.Cookies.Add(girisIsim);

                HttpCookie girisSifre = new HttpCookie("password");
                girisSifre.Expires = DateTime.Now.AddMinutes(10);
                girisSifre.Value = item.Password;
                Response.Cookies.Add(girisSifre);
            }
            if (aprep.Any
             (
             x => x.UserName == item.UserName &&
             x.Password == item.Password &&

             x.UserRole == Role.SuperAdmin
             ))
            {

                AppUser girisYapan = aprep.Default(x => x.UserName == item.UserName && x.Password == item.Password);
                if (girisYapan.IsActive == false)
                {
                    ViewBag.AktifDegil = "Lutfen Hesabınızı aktif hale getiriniz";
                    return View("RegisterOk");
                }
                Session["SuperAdmin"] = girisYapan;
                Session["user"] = (girisYapan.AppUserProfile.UserFirstName + " " + girisYapan.AppUserProfile.UserLastName);
                Session["userid"] = girisYapan.UserName;
               
                return RedirectToAction("ListEmployee","Employee",new { area="Admin"});
            }
            else if (aprep.Any
                (
                x => x.UserName == item.UserName &&
                x.Password == item.Password &&
                x.Status != DataStatus.Deleted &&
                x.IsBanned == false &&
                x.UserRole == Role.Admin
                ))
            {

                AppUser girisYapan = aprep.Default(x => x.UserName == item.UserName && x.Password == item.Password);
                if (girisYapan.IsActive == false)
                {
                    ViewBag.AktifDegil = "Lutfen Hesabınızı aktif hale getiriniz";
                    return View("RegisterOk");
                }
                Session["admin"] = girisYapan;
                Session["user"] = (girisYapan.AppUserProfile.UserFirstName + "" + girisYapan.AppUserProfile.UserLastName);
                Session["userid"] = girisYapan.UserName;
                return RedirectToAction("MovieList", "RealMovie", new { area = "Admin" });//burada Admin kendi areasına yönlendirilmeli
            }
             
            else if (aprep.Any
                (
                x => x.UserName == item.UserName &&
                x.Password == item.Password &&
                x.Status != DataStatus.Deleted &&
                x.IsBanned == false &&
                x.UserRole == Role.Member
                ))
            {
                AppUser girisYapan = aprep.Default(x => x.UserName == item.UserName && x.Password == item.Password);

                if (girisYapan.IsActive == false)
                {
                    ViewBag.AktifDegil = "Lutfen Hesabınızı aktif hale getiriniz";
                    return View("RegisterOk");
                }
                Session["member"] = girisYapan;
              Session["user"] = (girisYapan.AppUserProfile.UserFirstName+""+girisYapan.AppUserProfile.UserLastName);
                Session["userid"] = girisYapan.UserName;
                return RedirectToAction("Index", "Member");
            }
            ViewBag.KullaniciBulunamadi = "Kullanıcı adı veya şifreniz hatalı olabilir.Böyle bir kullanıcı bulunamadı.";
            return View();
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgotPassword(AppUser item)
        {
            if (aprep.Any(x=> x.Email==item.Email))
            {
                string gonderilecekMail = "Şifre sıfırlama talebiniz oluşturuldu. https://localhost:44317/Home/ResetPassword/" + item.ResetPasswordCode + " linkine tıklayarak şifrenizi sıfırlayabilirsiniz.";

                MailSender.Send(item.Email, password: "Sinema123", body: gonderilecekMail, subject: "Şifre Sıfırlama Talebi");
            }
            else
            {
                ViewBag.MailGecersiz = "Bu mail kayıtlı değildir";
            }
            return View();
        }
        public ActionResult ResetPassword(int id)
        {
            return View(aprep.GetByID(id));
        }
        [HttpPost]
        public ActionResult ResetPassword(AppUser item)
        {
            aprep.Update(item);
            return View();
        }
        public AppUser CheckCookie()
        {
            string userName = string.Empty, password = string.Empty;

            AppUser cookiedeSaklanan = null;

            //Var olan bir cookie Request property'si ile kontrol edilebilir.
            if (Request.Cookies["userName"] != null && Request.Cookies["password"] != null)
            {
                userName = Request.Cookies["userName"].Value;
                password = Request.Cookies["password"].Value;
            }
            //Asagıda Cookie null olmasa bile Cookie'nin degerinin (firstName ve password'un) bos veya null olmadıgını garantiledik.
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                cookiedeSaklanan = new AppUser
                {
                    UserName = userName,
                    Password = password
                };
            }

            return cookiedeSaklanan;
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();  // it will clear the session at the end of request
            return RedirectToAction("Login", "Home");
        }
    }

}

