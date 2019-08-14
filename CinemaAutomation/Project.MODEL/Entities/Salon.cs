using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Salon: BaseEntity
    {
        public int SalonID { get; set; }
        public string SalonName { get; set; }
        public decimal Capacity { get; set; }

        //Relational Properties

        public virtual Movie Movie { get; set; }
        public virtual List<Seans> Seans { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
