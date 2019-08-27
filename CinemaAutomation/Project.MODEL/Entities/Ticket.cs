﻿using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Ticket: BaseEntity
    {
        public int TicketID { get; set; }
        public TicketSalesType TicketSalesType { get; set; }
        public decimal TicketPrice { get; set; }
        public short TicketCount { get; set; }
        public TicketGenre TicketGenre { get; set; }
        public decimal Discount
        {
            get
            {
                if (TicketGenre == TicketGenre.Student)
                {
                    Discount = 0.4m;
                }
                return Discount;
            }
            set { }
        }

        public Ticket()
        {
            if(TicketCount == ' ')
            {
                TicketCount = 0;
            }
            else
            {
                TicketCount++;
            }
        }

        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Salon Salon { get; set; }
        public virtual Seans Seans { get; set; }
        public virtual Employee Employee { get; set; } //bileti kesen kasiyerin ismi fişte yazacak.
        public virtual AppUserProfile AppUserProfile { get; set; }
    }
}
