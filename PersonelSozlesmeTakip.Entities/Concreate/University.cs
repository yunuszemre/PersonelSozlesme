using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class University : BaseEntity<Guid>
    {
        public string City { get; set; }
        

        public List<Campus> Campuses { get; set; }




    }
}
