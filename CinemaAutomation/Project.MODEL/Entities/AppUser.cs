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
      
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsBanned { get; set; }
        public bool IsActive { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public Guid? ActivationCode { get; set; }
        public Role UserRole { get; set; }
        public bool SmsMessage { get; set; }   //Kayıt ekranında kullanılacak. 
        public string UserComment { get; set; }
        public int EmailID { get; set; }
        public Guid? ResetPasswordCode { get; set; }
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
