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
   public class GenreRepository:BaseRepository<Genre>
    {
        MyContext db;
        public GenreRepository()
        {
            db = DBTool.DBInstance;
        }
        public void Update(Genre item)
        {
            item.Status = DataStatus.Updated;

            item.ModifiedDate = DateTime.Now;
            Genre toBeUpdated = GetByID(item.GenreID);

            db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
    }
}
