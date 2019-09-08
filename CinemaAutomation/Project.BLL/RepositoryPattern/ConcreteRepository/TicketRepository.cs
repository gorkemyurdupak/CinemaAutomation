using Project.BLL.RepositoryPattern.BaseRepository;
using Project.BLL.SingletonPattern;
using Project.DAL.Context;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.RepositoryPattern.ConcreteRepository
{
    public class TicketRepository:BaseRepository<Ticket>
    {
        Ticket tick;
        MyContext db = DBTool.DBInstance;
        public List<Ticket> BoxTicket()
        {
            return db.Set<Ticket>().Where(x => x.TicketSalesType == TicketSalesType.BoxOffice).ToList();
        } 
        public List<Ticket> InternetTicket()
        {
            return db.Set<Ticket>().Where(x => x.TicketSalesType == TicketSalesType.Internet).ToList();
        }
        public List<Ticket> BothTicket()
        {
           return db.Set<Ticket>().Where(x => x.TicketCount == tick.TicketCount).ToList();
        }
    }
}
