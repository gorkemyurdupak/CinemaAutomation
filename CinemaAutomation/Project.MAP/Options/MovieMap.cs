using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class MovieMap:BaseMap<Movie>
    {
        public MovieMap()
        {
            Property(x => x.MovieName).HasMaxLength(50).IsRequired();
            Property(x => x.Director).IsRequired();
            Property(x => x.MovieSummary).HasMaxLength(1000);
            Property(x => x.MovieComment).HasMaxLength(500).IsOptional();
        }
    }
}
