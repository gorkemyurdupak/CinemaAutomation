﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class MovieSeans: BaseEntity
    {
        public int MovieID { get; set; }
        public int SeansID { get; set; }

        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Seans Seans { get; set; }
    }
}
