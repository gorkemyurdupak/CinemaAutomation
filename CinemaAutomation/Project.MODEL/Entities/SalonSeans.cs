using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class SalonSeans:BaseEntity
    {
        public int SeansID { get; set; }
        public int SalonID { get; set; }


        //Relational Properties
        public virtual Seans Seans { get; set; }
        public virtual Salon Salon { get; set; }
    }
}
