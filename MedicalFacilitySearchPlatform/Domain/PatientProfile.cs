using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PatientProfile : BaseEntity
    {
        public string? MedicalHistory { get; set; }
        public string? Allergies { get; set; }  
        public string? ChronicConditions { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        //r
        public Guid? UserId { get; set; }
        public GenericUser? User { get; set; }
        public Guid? MedicalFacilityId { get; set; }
        public virtual MedicalFacility? MedicalFacility { get; set; }
        public virtual IEnumerable<MedicalRecords>? PatientProfiles { get; set; }
        public virtual IEnumerable<Review>? Reviews { get; set; }
        public virtual IEnumerable<Appointments>? Appointments { get; set; }
    }
}
