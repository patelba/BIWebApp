using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BIWebApp.Data
{
    public partial class BI_K3_Costs : BaseEntity
    {
        
        public int BI_CostID { get; set; }
        [DisplayName("Role Type")]
        public string Role_Type { get; set; }
        [DisplayName("Role Name")]
        public string Role_Name { get; set; }
        [DisplayName("Daily Cost")]
        public Nullable<decimal> Daily_Cost { get; set; }
        [DisplayName("Hourly Cost")]
        public Nullable<decimal> Hourly_Cost { get; set; }
    }
}
