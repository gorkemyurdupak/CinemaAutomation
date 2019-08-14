using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Cinema:BaseEntity
    {
        public int CinemaID { get; set; }
        public string CinemaName { get; set; }
        public string CinemaAddress { get; set; }
        public decimal CinemaPhone { get; set; }

        //Relational Properties

        public virtual List<Movie> Movies { get; set; }
        public virtual List<Salon> Salons { get; set; }
        public virtual List<Seans> Seans { get; set; }
        public virtual List<Employee> Employees { get; set; } //Buna gerek olmayabilir.Cinemaximum gibi eğer sadece bilet satın alma işlemleri için kullanacaksak,bu ekstra bir class olur.Ancak bir sinemada çalışanların da olması gerekir.Belirli olan sinemaya (akasya avm vb.) eklenecek filmleri girecek olan çalışanlar olmalıdır.
        
    }
}
