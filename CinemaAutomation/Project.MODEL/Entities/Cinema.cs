using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Cinema:BaseEntity
    {
        public int CinemaID { get; set; }
        public string CinemaName { get; set; }
        public string CinemaAddress { get; set; }
        public decimal CinemaPhone { get; set; }
    }
}
