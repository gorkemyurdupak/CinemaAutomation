using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Movie: BaseEntity
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public decimal ScreenTime { get; set; }
        public DateTime ShowDate { get; set; }
        public Genre MovieGenre { get; set; }
        public decimal SalonNumber { get; set; }
        public string ImagePath { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Format { get; set; }
        public string MovieSummary { get; set; }
        public string MovieComment { get; set; }
        public bool IsPlaying { get; set; }

        //Relational Properties
        public virtual List<Ticket> Tickets { get; set; }



    }
}
