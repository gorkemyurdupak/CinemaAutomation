using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Movie: BaseEntity
    {
        public int GenreID { get; set; }
        public int MovieID { get; set; }
        public string MovieName { get; set; }

        [Required]
        //[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        [Range(0,225)]
        public int ScreenTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd mmm yyyy}")] //otomatik saat belirliyor.Çağırıldığı yerde ToString vs tarzı bir metot ile kullanılabilme şansı var.Veritabanından olmuyor gibi gözüküyor.
        public DateTime? ShowDate { get; set; }
        public string ImagePath { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Format { get; set; } //2D,3D,Altyazı vs...
        public string MovieSummary { get; set; }
        [Range(0,10)]
        public decimal? Rating { get; set; }
        public string MovieComment { get; set; }
        public bool IsPlaying { get; set; } //Vizyon da mı, değil mi ?

        public Movie()
        {
            IsPlaying = true;
        }

        //Relational Properties
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Salon> Salons { get; set; }
        public virtual Genre MovieGenre { get; set; }
        public virtual List<MovieSeans> MovieSeanss { get; set; }

    }
}
