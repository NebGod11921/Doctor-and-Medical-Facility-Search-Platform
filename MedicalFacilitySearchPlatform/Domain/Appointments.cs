using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointments : BaseEntity
    {
        public DateTime? MeetingDate { get; set; }
        public string? Notes { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        //r
        public Guid? FeeId { get; set; }
        public virtual Fees? Fee { get; set; }
        public Guid? MedicalFacilityId { get; set; }
        public virtual MedicalFacility? MedicalFacility { get; set; }
        public Guid? PatientProfileId { get; set; }
        public virtual PatientProfile? PatientProfile { get; set; }
        public Guid? DoctorProfileId { get; set; }
        public virtual DoctorProfile? DoctorProfile { get; set; }
    }
}
