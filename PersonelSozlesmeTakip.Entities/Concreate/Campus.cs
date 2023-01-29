﻿using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Campus : BaseEntity
    {
        public Campus()
        {
            this.Faculties = new List<Faculty>();
        }
        public Guid UniversityId { get; set; }

        public virtual University University { get; set; }

        public virtual List<Faculty> Faculties { get; set; }

    }
}
