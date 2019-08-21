using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class SalonSeans
    {
        public virtual List<Seans> Seans { get; set; }
        public virtual List<Salon> Salon { get; set; }
    }
}
