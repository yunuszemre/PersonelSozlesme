using PersonelSozlesmeTakip.Core.Concreate;
using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Admin : BaseEntity<Guid>
    {
        public Admin()
        {
            this.Faculties = new List<Faculty>();
            this.Universities = new List<University>();
        }
        public Role Role { get; set; }
        public List<University> Universities { get; set; }

        public List<Faculty> Faculties { get; set; }
    }
}
