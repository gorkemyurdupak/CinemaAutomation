using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Employee : BaseEntity
    {
        public int EmployeeID { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string Extensions { get; set; }
        public string Photo { get; set; } //todo MAP katmanında null geçilebilir olması sağlanacak.
        public string PhotoPath { get; set; } //todo MAP katmanında null geçilebilir olması sağlanacak.
        public int? ReportsTo { get; set; }
        public string Address { get; set; }



        //Relational Properties

    }
}
