using System;
using System.Collections.Generic;

namespace BIWebApp.Data
{
    public partial class BI_NavisionResource : BaseEntity
    {
        public Nullable<long> ResourceNo { get; set; }
        public string ResourceName { get; set; }
        public string ResourceEmailAddress { get; set; }
    }
}
