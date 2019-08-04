using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public abstract class AppUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public decimal Phone { get; set; } //fluentapi ile kısıtlama yapılıyordu galiba.Hangisi olduğunu bulup buraya max girilecek karakter yapılmalı.

    }
}
