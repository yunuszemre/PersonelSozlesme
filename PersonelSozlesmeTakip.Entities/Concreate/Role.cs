using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Role : BaseEntity
    {
        public Role()
        {
            
            this.Personels = new List<RolePersonel>();
        }
        

        public List<RolePersonel> Personels { get; set; }
    }
}
