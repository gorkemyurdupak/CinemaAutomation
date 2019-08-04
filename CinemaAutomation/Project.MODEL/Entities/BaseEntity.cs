﻿using Project.MODEL.Enums;
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
        public DateTime? DeletedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public DataStatus Status { get; set; }
        public Role UserRole { get; set; }

        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            UserRole = Role.Visitor;
            CreatedDate = DateTime.Now;
        }
    }
}
