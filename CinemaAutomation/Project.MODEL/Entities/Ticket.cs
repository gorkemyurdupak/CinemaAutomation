﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Ticket: BaseEntity
    {
        public int TicketID { get; set; }
        public decimal TicketPrice { get; set; }
        public decimal TicketCount { get; set; }

        public Ticket()
        {
            TicketCount++;
        }

        //Relational Properties
        public virtual Movie Movie { get; set; }

    }
}
