using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class SalonSeansMap:BaseMap<SalonSeans>
    {
        public SalonSeansMap()
        {
            Ignore(x => x.ID);

            HasKey(x => new { x.SalonID,x.SeansID });
        }
    }
}
