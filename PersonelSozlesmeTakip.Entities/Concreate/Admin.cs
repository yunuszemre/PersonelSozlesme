using PersonelSozlesmeTakip.Core.Concreate;
using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Admin : BaseEntity
    {
        
        public Role Role { get; set; }
        public virtual List<University> Universities { get; set; }

        public virtual List<Faculty> Faculties { get; set; }
    }
}
