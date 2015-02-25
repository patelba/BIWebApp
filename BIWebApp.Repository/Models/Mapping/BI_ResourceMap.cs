using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BIWebApp.Data;

namespace BIWebApp.Repository.Models.Mapping
{
    public class BI_ResourceMap : EntityTypeConfiguration<BI_Resource>
    {
        public BI_ResourceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProjectUID, t.ProjectName });

            // Properties
            this.Property(t => t.Customer_Name)
                .HasMaxLength(4000);

            this.Property(t => t.ProjectName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.NTNAME)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("BI_Resource");
            this.Property(t => t.Customer_Name).HasColumnName("Customer Name");
            this.Property(t => t.ProjectUID).HasColumnName("ProjectUID");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.NTNAME).HasColumnName("NTNAME");
        }
    }
}
