using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class SeansMap:BaseMap<Seans>
    {
        public SeansMap()
        {
            Ignore(x => x.ID);
            //Property(x => x.SeansTime).IsRequired();
        }
    }
}
