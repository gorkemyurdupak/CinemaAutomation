using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Employee:AppUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
