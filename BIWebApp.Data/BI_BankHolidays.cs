using System;
using System.Collections.Generic;

namespace BIWebApp.Data
{
    public partial class BI_BankHolidays : BaseEntity
    {
        public System.DateTime Date { get; set; }
        public string BaseCalendar { get; set; }
        public Nullable<int> BHCount { get; set; }
    }
}
