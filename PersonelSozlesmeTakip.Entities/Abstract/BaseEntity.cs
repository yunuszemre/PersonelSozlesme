using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Abstract
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CerateDate { get; set; } = DateTime.Now;

        public DateTime ModifiedDate { get; set; }

    }
}
