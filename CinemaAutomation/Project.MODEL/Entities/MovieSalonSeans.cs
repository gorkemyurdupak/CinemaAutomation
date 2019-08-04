using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class MovieSalonSeans
    {
        public int MovieSalonSeansID { get; set; }
        public int SeansID { get; set; }
        public int SalonID { get; set; }
        public int MovieID { get; set; }

    }
}
