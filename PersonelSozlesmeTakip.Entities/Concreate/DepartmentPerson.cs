using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class DepartmentPerson
    {
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public Guid PersonelId { get; set; }
        public Personel Personel { get; set; }
    }
}
