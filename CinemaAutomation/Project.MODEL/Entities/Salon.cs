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
    }
}
