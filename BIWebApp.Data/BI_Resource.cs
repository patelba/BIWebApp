using System;
using System.Collections.Generic;

namespace BIWebApp.Data
{
    public partial class BI_Resource : BaseEntity
    {
        public string Customer_Name { get; set; }
        public System.Guid ProjectUID { get; set; }
        public string ProjectName { get; set; }
        public string NTNAME { get; set; }
    }
}
