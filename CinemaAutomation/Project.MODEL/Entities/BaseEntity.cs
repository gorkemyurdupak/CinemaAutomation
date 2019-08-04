using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Role UserRole { get; set; }    
        //bu ve ctor içerisindekinin appuser da olması daha mantıklı olabilir.Orada oluşabilecek tek sorun hem customer hem de employee sınıflarına miras veriyor olması. Yani employee kısmının visitor değil admin kısmına geçmesi gerekecek,customer ise member veya visitor olacak.Ctor anında ikisi de visitor olarak geldiği için ona bir ayar yapmak gerekecek.
                                              
        public DataStatus Status { get; set; }  

        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            UserRole = Role.Visitor;
            CreatedDate = DateTime.Now;
        }
    }
}
