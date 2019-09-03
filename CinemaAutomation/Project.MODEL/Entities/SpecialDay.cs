using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class SpecialDay: BaseEntity
    {
        public DateTime Day { get; set; } //kontrol edilsin neden boş geçilemediği.
        public string DayName { get; set; }
        public bool IsSpecialDay { get; set; }

    }
}
