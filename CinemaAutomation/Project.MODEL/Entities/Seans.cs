﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Seans: BaseEntity
    {
        public int SeansID { get; set; }
        [DisplayFormat(DataFormatString = "{dddd, dd MMMM yyyy HH:mm:ss}")]
        public DateTime SeansTime { get; set; } 

        
        //Relational Properties
        public virtual List<MovieSeans> MovieSeanss { get; set; }
        public virtual List<SalonSeans> SalonSeanss { get; set; }


    }
}
