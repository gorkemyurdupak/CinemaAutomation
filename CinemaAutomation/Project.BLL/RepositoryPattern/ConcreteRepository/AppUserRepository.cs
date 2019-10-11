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
   public class AppUserRepository:BaseRepository<AppUser>
    {
        MyContext db;
      

        public AppUserRepository()
        {
            db = DBTool.DBInstance;
        }
        public void Update(AppUser item)
        {
            item.Status = DataStatus.Updated;

            item.ModifiedDate = DateTime.Now;
            AppUser toBeUpdated = GetByID(item.ID);

            db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
    }
}
