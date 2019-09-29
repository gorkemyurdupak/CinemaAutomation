using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Models.MyTools
{
    public class CartItem
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public short Amount { get; set; }

        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }

        public bool EmptyControl { get; set; }
        public int ChairID { get; set; }
        public TicketType TicketType { get; set; }
        public decimal SubTotal
        {
            get
            {
                return Price * Amount;
            }

        }

        public CartItem()
        {
            Amount = 1;
        }
        
    }
}