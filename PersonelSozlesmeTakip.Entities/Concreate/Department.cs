﻿using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Department : BaseEntity
    {

        public Guid FacultyId { get; set; }        
        public virtual Faculty? Faculty { get; set; }

        public virtual ICollection<DepartmentPerson> Personels { get; set; }

    }
}
