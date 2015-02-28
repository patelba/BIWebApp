using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BIWebApp.Data
{
    public partial class BI_K3_Costs : BaseEntity
    {
        
        public int BI_CostID { get; set; }
        [DisplayName("Role Type")]
        [Required(ErrorMessage = "Role Type needs to be entered")]
        public string Role_Type { get; set; }

        [DisplayName("Role Name")]
        [Required(ErrorMessage = "Role Name needs to be entered")]
        public string Role_Name { get; set; }

        [DisplayName("Daily Cost")]
        [Required(ErrorMessage = "Daily cost needs to be entered")]
        public Nullable<decimal> Daily_Cost { get; set; }

        [DisplayName("Hourly Cost")]
        [Required(ErrorMessage = "Hourly cost needs to be entered")]
        public Nullable<decimal> Hourly_Cost { get; set; }
    }
}
