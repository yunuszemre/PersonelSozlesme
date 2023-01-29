using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class RolePersonel
    {
        public Guid RoleId { get; set; }

        public Role Role { get; set; }

        public Guid PersonelId { get; set; }
        public Personel Personel { get; set; }
    }
}
