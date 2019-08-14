using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Seans: BaseEntity
    {
        public int SeansID { get; set; }
        public DateTime? MovieTime { get; set; }

        //Relational Properties

        public virtual List<Salon> Salons { get; set; } //Örneğin saat 11.00 seansının birden fazla salonda olması.
    }
}
