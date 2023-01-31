using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class University : BaseEntity
    {
        //public University()
        //{
        //    this.Faculties = new List<Faculty>();
        //    this.Campuses = new List<Campus>();
        //}
        public string City { get; set; }

        public string? LogoPath { get; set; }
        public Guid AdminId { get; set; }

        public virtual Admin? Admin { get; set; }
        public virtual List<Campus>? Campuses { get; set; }

        public virtual List<Faculty>? Faculties { get; set; }




    }
}
