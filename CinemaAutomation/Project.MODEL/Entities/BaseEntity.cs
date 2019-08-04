using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
<<<<<<< HEAD
    public abstract class BaseEntity
=======
   public abstract class BaseEntity
>>>>>>> af903bc2bb6895832b154144f85f72a5b9420007
    {
        public int ID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
<<<<<<< HEAD
        public DateTime? ModifiedDate { get; set; }

        public DataStatus Status { get; set; }
        public Role UserRole { get; set; }

        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            UserRole = Role.Visitor;
            CreatedDate = DateTime.Now;
=======

        public DateTime? ModifiedDate { get; set; }

        //public bool IsBanned { get; set; } //todo customer içerisinde olması yeterli olabilir.Tekrar değerlendirilmeli.

        public DataStatus Status { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
>>>>>>> af903bc2bb6895832b154144f85f72a5b9420007
        }
    }
}
