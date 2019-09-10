using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class SpecialDayMap:BaseMap<SpecialDay>
    {
        public SpecialDayMap()
        {
            Property(x => x.DayName).HasMaxLength(50).IsRequired();

        }
    }
}
