using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class Seat: BaseEntity
    {
        public int SeatID { get; set; }
        public decimal SeatNumber { get; set; } // Hangi Numara olduğu => G-1 ,F-3 .. 
        public char SeatLetter { get; set; } //Hangi sıra olduğu e-f-g  vs...

        //Relational Properties
        public virtual Salon Salon { get; set; }
    }
}
