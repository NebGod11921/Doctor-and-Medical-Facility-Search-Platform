using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Fees : BaseEntity
    {
        public SqlMoney? Amount { get; set; }
        public Enum? Currency { get; set; }
        public PaidStatus? PaidStatus { get; set; }
        public DateTime? PaymentDate { get; set; }

        //re
        public virtual Appointments? Appointments { get; set; }
    }
}
