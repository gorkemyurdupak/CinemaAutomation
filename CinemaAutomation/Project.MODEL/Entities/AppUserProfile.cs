using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class AppUserProfile: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Age { get; set; }
        public Role UserRole { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal Phone { get; set; } //fluentapi ile kısıtlama yapılıyordu galiba.Hangisi olduğunu bulup buraya max girilecek karakter yapılmalı.

        public AppUserProfile()
        {
            UserRole = Role.Visitor;
        }

    }
}
