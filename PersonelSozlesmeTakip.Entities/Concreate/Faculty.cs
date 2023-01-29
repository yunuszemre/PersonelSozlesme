using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Faculty : BaseEntity<Guid>
    {
        public Faculty()
        {
            this.Personels = new List<Personel>();
            this.Departments = new List<Department>();
        }

        public string Adress { get; set; }
        [ForeignKey("Campus")]
        public Guid CampusId { get; set; }

        public virtual Campus? Campus { get; set; }

        public List<Personel> Personels { get; set; }
        public List<Department> Departments { get; set; }
    }
}
