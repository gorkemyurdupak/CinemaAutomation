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

        public Role Role { get; set; }
    }
}
