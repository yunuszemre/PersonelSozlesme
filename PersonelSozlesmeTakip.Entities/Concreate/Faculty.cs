using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Faculty : BaseEntity<Guid>
    {
        public Faculty()
        {
            this.Departments = new List<Department>();
        }

        public string Adress { get; set; }
        public List<Department> Departments { get; set; }
    }
}
