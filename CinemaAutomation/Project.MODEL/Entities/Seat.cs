using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class Seat
    {
        public int SalonID { get; set; }
        public int ChairID { get; set; }
        public decimal ChairNumber { get; set; } // Hangi Numara olduğu => G-1 ,F-3 .. 
        public decimal ChairLetter { get; set; } //Hangi sıra olduğu e-f-g  vs...
    }
}
