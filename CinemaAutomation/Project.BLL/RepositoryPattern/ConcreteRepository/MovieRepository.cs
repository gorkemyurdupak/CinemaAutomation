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
   public class MovieRepository:BaseRepository<Movie>
    {
        MyContext db;
        public MovieRepository()
        {
            db = DBTool.DBInstance;
        }
        public void Update(Movie item)
        {
            item.Status = DataStatus.Updated;

            item.ModifiedDate = DateTime.Now;
            Movie toBeUpdated = GetByID(item.MovieID);

            db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
    }
}
