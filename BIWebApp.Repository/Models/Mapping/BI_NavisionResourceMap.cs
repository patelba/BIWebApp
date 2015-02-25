using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BIWebApp.Data;

namespace BIWebApp.Repository.Models.Mapping
{
    public class BI_NavisionResourceMap : EntityTypeConfiguration<BI_NavisionResource>
    {
        public BI_NavisionResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.ResourceName);

            // Properties
            this.Property(t => t.ResourceName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ResourceEmailAddress)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("BI_NavisionResource");
            this.Property(t => t.ResourceNo).HasColumnName("ResourceNo");
            this.Property(t => t.ResourceName).HasColumnName("ResourceName");
            this.Property(t => t.ResourceEmailAddress).HasColumnName("ResourceEmailAddress");
        }
    }
}
