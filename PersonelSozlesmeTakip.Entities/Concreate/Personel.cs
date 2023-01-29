using PersonelSozlesmeTakip.Core.Concreate;
using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Entities.Concreate
{
    public class Personel : BaseEntity<Guid>
    {
        public Personel()
        {
            this.Departments = new List<DepartmentPerson>();
            this.Roles = new List<RolePersonel>();
        }
        
        public List<RolePersonel> Roles { get; set; }
        public string? Email { get; set; }

        public string LastName { get; set; }
        public string? ImagePath { get; set; }
        public string? IntegratedPhone { get; set; }

        public Guid FacultyId { get; set; }

        public Faculty? Faculty { get; set; }

        public virtual ICollection<DepartmentPerson> Departments { get; set; }
        public DateTime? ContractEndDate { get; set; }

        public DateTime ContractStartDate { get; set; }

        public string? Phone { get; set; }


    }
}
