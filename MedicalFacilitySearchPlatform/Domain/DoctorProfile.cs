using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DoctorProfile : BaseEntity
    {
        public string? Specialization { get; set; }
        public string? Experience { get; set; } 
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? Qualifications { get; set; }
        public int? WorkingHours { get; set; }

        //r
        public Guid? UserId { get; set; }
        public virtual GenericUser? User { get; set; }
        public virtual IEnumerable<MedicalRecords>? PatientProfiles { get; set; }
        public virtual IEnumerable<Review>? Reviews { get; set;}
        public virtual IEnumerable<Appointments>? Appointments { get; set; }
    }
}
