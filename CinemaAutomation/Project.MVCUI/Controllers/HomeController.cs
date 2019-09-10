using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.COMMON.Tools;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

            string gonderilecekMail = "Tebrikler hesabınız oluşturuldu. Hesabınızı aktive etmek için http://localhost:59157/Home/Aktivasyon/" + item.ActivationCode + " linkine tıklayabilirsiniz.";  //MVCUI'a sağ tık,Properties den girdiğinde web kısmında url'i göreceksin.DÜZENLENECEK!!!!

            MailSender.Send(item.Email, password: "Cf8885++--", body: gonderilecekMail, subject: "Hesap Aktivasyon!");

            aprep.Add(item); // buradan sonra item'in id'si olusmus oluyor...O yüzden item2'nin id'sini verecek isek buradan sonra vermeliyiz.

            item2.ID = item.ID;

            apdrep.Add(item2);

            return View("RegisterOk");
        }

        public ActionResult Login()
        {
            return View();
        }

    
    }
}
