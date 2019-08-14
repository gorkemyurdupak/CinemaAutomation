using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class Genre: BaseEntity
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        public virtual List<Movie> Movies { get; set; }
    }
}
