using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class MovieSeansMap:BaseMap<MovieSeans>
    {
        public MovieSeansMap()
        {
            Ignore(x => x.ID);

            HasKey(x => new { x.MovieID,x.SeansID});
        }
    }
}
