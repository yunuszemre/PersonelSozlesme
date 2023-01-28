﻿using PersonelSozlesmeTakip.Core.Concreate;
using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Personel : BaseEntity<Guid>
    {
        [ForeignKey("DepartmentPerson")]
        public Guid DepartmentPersonId { get; set; }

        public DepartmentPerson DepartmentPerson { get; set; }

        public Role Role { get; set; }
        public string Email { get; set; }

        public string? IntegratedPhone { get; set; }

        public DateTime ContractEndDate { get; set; }

        public DateTime ContractStartDate { get; set; }

        public string Phone { get; set; }


    }
}
