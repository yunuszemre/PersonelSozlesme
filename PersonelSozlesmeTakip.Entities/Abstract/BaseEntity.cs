﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime CerateDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
