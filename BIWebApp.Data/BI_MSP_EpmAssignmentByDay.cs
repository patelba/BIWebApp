using System;
using System.Collections.Generic;

namespace BIWebApp.Data
{
    public partial class BI_MSP_EpmAssignmentByDay : BaseEntity
    {
        public long BILogID { get; set; }
        public System.Guid AssignmentUID { get; set; }
        public System.DateTime TimeByDay { get; set; }
        public System.Guid ProjectUID { get; set; }
        public System.Guid TaskUID { get; set; }
        public System.DateTime Date_Entered { get; set; }
        public int Status_Code { get; set; }
        public string Status_Description { get; set; }
        public Nullable<System.DateTime> AssignmentStartDate { get; set; }
        public Nullable<System.DateTime> AssignmentFinishDate { get; set; }
        public string ProjectName { get; set; }
        public string Project_Owner { get; set; }
        public System.Guid ResourceUID { get; set; }
        public string ResourceName { get; set; }
        public string Customer_Name { get; set; }
        public string Job_Number { get; set; }
        public string TaskName { get; set; }
    }
}
