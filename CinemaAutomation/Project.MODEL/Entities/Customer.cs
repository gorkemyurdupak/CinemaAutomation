using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class Customer: BaseEntity
    {

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
        public virtual AppUserProfile AppUserProfile { get; set; }

    }
}
