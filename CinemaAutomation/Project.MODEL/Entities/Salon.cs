using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Salon: BaseEntity
    {
        public int SalonID { get; set; }
        [Required]
        [Range(1,15)]//sinemayı büyütüp 10 veya üzeri salon açarlarsa diye önlemdir.
        public short SalonNumber { get; set; } 

        [Required]
        [Range(1,300)]
        public short Capacity { get; set; }

        //Relational Properties
        public virtual List<SalonSeans> SalonSeanss { get; set; }
        public virtual List<Seat> Seats { get; set; }
        public virtual Movie Movie { get; set; } //ticket bağlantısı olacak mı kontrol edilsin.


    }
}
