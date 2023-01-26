using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class DepartmentPerson:BaseEntity<Guid>
    {
        public DepartmentPerson()
        {
            this.Persons = new List<Personel>();
            this.Departments= new List<Department>();
        }
        public List<Personel> Persons { get; set; }

        public List<Department> Departments { get; set; }
    }
}
