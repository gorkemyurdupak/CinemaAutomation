using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Cinema:BaseEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }
       
        public decimal SalonNumber { get; set; } //salon sayısı
    }
}
