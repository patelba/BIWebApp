using System;
using System.Collections.Generic;

namespace BIWebApp.Data
{
    public partial class BI_Navision_ProjectServer : BaseEntity
    {
        public System.DateTime Date { get; set; }
        public string Job_Number { get; set; }
        public string Provisional { get; set; }
        public Nullable<decimal> Hours_Allocated { get; set; }
        public string Resource_Email_Address { get; set; }
        public Nullable<long> ResourceNo { get; set; }
        public Nullable<decimal> Project_Server_Hours { get; set; }
        public Nullable<decimal> Navision_Hours { get; set; }
    }
}
