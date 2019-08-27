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
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Address { get; set; }
        public decimal Phone { get; set; } //todo MAP katmanında kısıtlanacak.
        public SexStatus Sex { get; set; }
        public DateTime BirthDate { get; set; }


        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
    }
}
