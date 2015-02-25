using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BIWebApp.Data;

namespace BIWebApp.Repository.Models.Mapping
{
    public class BI_BankHolidaysMap : EntityTypeConfiguration<BI_BankHolidays>
    {
        public BI_BankHolidaysMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Date, t.BaseCalendar });

            // Properties
            this.Property(t => t.BaseCalendar)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("BI_BankHolidays");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.BaseCalendar).HasColumnName("BaseCalendar");
            this.Property(t => t.BHCount).HasColumnName("BHCount");
        }
    }
}
