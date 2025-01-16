using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Review : BaseEntity    
    {
        public int? Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public byte? IsEdited { get; set;}

        //re
        public Guid? DoctorProfileId { get; set; }
        public virtual DoctorProfile? DoctorProfile { get; set; }
        public Guid? PatientId { get; set; }
        public virtual PatientProfile? PatientProfile { get; set; }  
    }
}
