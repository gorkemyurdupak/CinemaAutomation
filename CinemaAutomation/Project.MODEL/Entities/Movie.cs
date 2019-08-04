using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public decimal MovieLength { get; set; }
        public decimal MoviePrice { get; set; }
        public DateTime? ShowTime { get; set; }

    }
}
