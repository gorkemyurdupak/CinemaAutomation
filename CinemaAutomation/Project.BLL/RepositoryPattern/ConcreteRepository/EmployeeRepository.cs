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
   public class EmployeeRepository:BaseRepository<Employee>
    {
        MyContext db;
        public EmployeeRepository()
        {
            db = DBTool.DBInstance;
        }
        public void Update(Employee item)
        {
            item.Status = DataStatus.Updated;

            item.ModifiedDate = DateTime.Now;
            Employee toBeUpdated = GetByID(item.EmployeeID);

            db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
    }
}
