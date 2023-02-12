using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Faculty : BaseEntity
    {
        
        public Guid AdminId { get; set; }
        public virtual Admin? Admin { get; set; }
        public string? LogoPath { get; set; }
        public string Adress { get; set; }
        
        
        public Guid CampusId { get; set; }

        public virtual Campus? Campus { get; set; }

        public Guid UniversityId { get; set; }

        public virtual University University { get; set; }

        public virtual List<Personel> Personels { get; set; }
        public virtual List<Department> Departments { get; set; }
        public override string ToString()
        {
            return $"{University.Name} {Name}";
        }
    }
}
