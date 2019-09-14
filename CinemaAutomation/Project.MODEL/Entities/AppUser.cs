using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsBanned { get; set; }
        public bool IsActive { get; set; }
      /*  [Compare("Password")]*/ //todo gerek olup olmadığı tartışılır.Şifrelerin eşleşmesini kontrol ediyor.Burada tek soru var, farklı farklı yerlerden çağırılırsa örneğin,login panelde bu özelliklere erişince confirmpasswordu de beraberinde getirir mi ? Eğer bu tarz bir sorun çıkarmayacaksa, compare kullanıp mapteki ignore'u kaldırmak daha iyi.
        public string ConfirmPassword { get; set; }
        public Guid? ActivationCode { get; set; }
        public Role UserRole { get; set; }
        public bool SmsMessage { get; set; }   //Kayıt ekranında kullanılacak. 
        public string UserComment { get; set; }
        public int EmailID { get; set; }
        public string ResetPasswordCode { get; set; }
        public string Email { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public Progress MembershipProgress { get; set; }
        public AppUser()
        {
            UserRole = Role.Member;
            ActivationCode = Guid.NewGuid();
            MembershipProgress = Progress.Checked;
        }

        //Relational Properties
        public virtual AppUserProfile AppUserProfile { get; set; }
 

    }
}
