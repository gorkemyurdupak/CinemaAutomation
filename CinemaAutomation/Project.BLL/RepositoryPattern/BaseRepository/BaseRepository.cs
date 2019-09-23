using Project.BLL.RepositoryPattern.InterfaceRepository;
using Project.BLL.SingletonPattern;
using Project.DAL.Context;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.RepositoryPattern.BaseRepository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext db;
        Employee emp;

        public BaseRepository()
        {
            db = DBTool.DBInstance;
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public void Add(T item)
        {
            db.Set<T>().Add(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public T Default(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().FirstOrDefault(exp);
        }

        public void Delete(T item)
        {
            item.Status = DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            
            Save();
        }

        public T GetByID(int id)
        {
            return db.Set<T>().Find(id);
        }

        public object ListAnonymus(Expression<Func<T, object>> exp)
        {
            return db.Set<T>().Select(exp).ToList();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return db.Set<T>().Select(exp);
        }

        public List<T> SelectActives()
        {
            return db.Set<T>().Where(x => x.Status != DataStatus.Deleted).ToList();
        }

        public List<T> SelectAll()
        {
            return db.Set<T>().ToList();
        }

        public List<T> SelectDeleteds()
        {
            return db.Set<T>().Where(x => x.Status == DataStatus.Deleted).ToList();
        }

        public List<T> SelectModifieds()
        {
            return db.Set<T>().Where(x => x.Status == DataStatus.Updated).ToList();
        }

        public void SpecialDelete(int id)
        {
            db.Set<T>().Remove(GetByID(id));
            Save();
        }

        public void Update(T item)
        {
            item.Status = DataStatus.Updated;

            item.ModifiedDate = DateTime.Now;
            T toBeUpdated = GetByID(item.ID);

            db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }

    }
}
