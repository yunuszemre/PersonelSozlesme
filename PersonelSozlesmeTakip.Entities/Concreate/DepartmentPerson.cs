using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class DepartmentPerson
    {
        
        public Guid PersonelId { get; set; }

        public virtual Personel? Personel { get; set; }
        public Guid DepartmentId { get; set; }
        public virtual Department? Department { get; set; }

    }
}
