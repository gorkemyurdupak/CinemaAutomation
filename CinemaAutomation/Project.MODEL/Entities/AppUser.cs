using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
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
        public string ConfirmPassword { get; set; }
        public Guid? ActivationCode { get; set; }
        public Role UserRole { get; set; }
        public bool SmsMessage { get; set; }   //Kayıt ekranında kullanılacak. 
        public bool EmailMessage { get; set; }
        public string UserComment { get; set; }
        public AppUser()
        {
            UserRole = Role.Member;
            ActivationCode = Guid.NewGuid();

        }

        //Relational Properties

        public virtual AppUserProfile AppUserProfile { get; set; }

    }
}
