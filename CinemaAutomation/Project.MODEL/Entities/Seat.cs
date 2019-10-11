using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class Seat: BaseEntity
    {
        public int SeatID { get; set; }
        [Required] //data annotationlar kontrol edilecek.MaxLength'ler decimal,short vs de farklı mı olacak ? 
      
        public short SeatNumber { get; set; } // Hangi Numara olduğu => G-1 ,F-3 .. 
        [Required]
        [MaxLength(1)]
        public string SeatLetter { get; set; } //Hangi sıra olduğu e-f-g  vs...

        public bool IsEmpty { get; set; }

        public Seat()
        {
            IsEmpty = true;
        }
        //Relational Properties
        public virtual Salon Salon { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
