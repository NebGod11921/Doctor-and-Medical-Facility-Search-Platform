using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MedicalRecords : BaseEntity
    {
        public string? Diagnosis { get; set; }
        public string? Prescriptions { get; set; }
        public string? TestResultUrl { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }


        //r
        public Guid? PatientProfileId { get; set; }
        public virtual PatientProfile? PatientProfile { get; set; }
        public Guid? DoctorProfileId { get; set; }
        public virtual DoctorProfile? DoctorProfile { get; set; }
    }
    
}
