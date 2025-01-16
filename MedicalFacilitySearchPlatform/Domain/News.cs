using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class News : BaseEntity
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? DatePublished { get; set; }
        public Tags? Tags { get; set;}

        //r
        public Guid? UserId { get; set;}
        public virtual GenericUser? User { get; set;}
        
    }
}
