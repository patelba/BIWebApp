using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BIWebApp.Data;

namespace BIWebApp.Repository.Models.Mapping
{
    public class BI_Navision_ProjectServerMap : EntityTypeConfiguration<BI_Navision_ProjectServer>
    {
        public BI_Navision_ProjectServerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Date, t.Provisional });

            // Properties
            this.Property(t => t.Job_Number)
                .HasMaxLength(4000);

            this.Property(t => t.Provisional)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Resource_Email_Address)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("BI_Navision_ProjectServer");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Job_Number).HasColumnName("Job Number");
            this.Property(t => t.Provisional).HasColumnName("Provisional");
            this.Property(t => t.Hours_Allocated).HasColumnName("Hours Allocated");
            this.Property(t => t.Resource_Email_Address).HasColumnName("Resource Email Address");
            this.Property(t => t.ResourceNo).HasColumnName("ResourceNo");
            this.Property(t => t.Project_Server_Hours).HasColumnName("Project Server Hours");
            this.Property(t => t.Navision_Hours).HasColumnName("Navision Hours");
        }
    }
}
