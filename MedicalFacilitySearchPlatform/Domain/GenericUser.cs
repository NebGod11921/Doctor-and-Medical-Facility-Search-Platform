using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GenericUser : BaseEntity
    {
        public string? EmailAddress { get; set; }
        public string? PasswordHash { get; set; }
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public string? Avatar { get; set; }
        public string? ConfirmationToken { get; set; }
        public byte? IsConfirmed { get; set; }
        public Role? Role { get; set; }

        //r
        public virtual IEnumerable<News>? News { get; set; }
        public virtual PatientProfile? PatientProfile { get; set; }
        public virtual DoctorProfile? DoctorProfile { get; set; }
    }
}
