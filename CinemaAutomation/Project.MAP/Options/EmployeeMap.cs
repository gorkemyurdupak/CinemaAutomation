using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class EmployeeMap:BaseMap<Employee>
    {
        public EmployeeMap()
        {
            Property(x => x.EmpFirstName).HasMaxLength(20).IsRequired();
            Property(x => x.EmpLastName).HasMaxLength(20).IsRequired();
            Property(x => x.Address).HasMaxLength(300).IsOptional();
            Property(x => x.Title).IsOptional();
            Property(x => x.TitleOfCourtesy).IsOptional();
            Property(x => x.Photo).IsOptional();
            Property(x => x.PhotoPath).IsOptional();
            Property(x => x.ReportsTo).IsOptional();
            Property(x => x.Extensions).IsOptional().HasMaxLength(4);
        }
    }
}
