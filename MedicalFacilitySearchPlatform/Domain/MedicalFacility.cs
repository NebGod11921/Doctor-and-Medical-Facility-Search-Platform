using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MedicalFacility : BaseEntity
    {
        public string? FacilityName { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public FacilityType? FacilityType { get; set; }
        public DateTime? DateEstablished { get; set; }
    
        //r
        public virtual IEnumerable<DoctorProfile>? DoctorProfiles { get; set; }
        public virtual IEnumerable<Appointments>? Appointments { get; set; }    
    }
}
