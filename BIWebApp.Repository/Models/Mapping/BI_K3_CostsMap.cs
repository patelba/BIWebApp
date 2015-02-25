using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BIWebApp.Data;

namespace BIWebApp.Repository.Models.Mapping
{
    public class BI_K3_CostsMap : EntityTypeConfiguration<BI_K3_Costs>
    {
        public BI_K3_CostsMap()
        {
            // Primary Key
            this.HasKey(t => t.BI_CostID);

            // Properties
            this.Property(t => t.Role_Type)
                .HasMaxLength(4000);

            this.Property(t => t.Role_Name)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("BI_K3_Costs");
            this.Property(t => t.BI_CostID).HasColumnName("BI_CostID");
            this.Property(t => t.Role_Type).HasColumnName("Role_Type");
            this.Property(t => t.Role_Name).HasColumnName("Role Name");
            this.Property(t => t.Daily_Cost).HasColumnName("Daily Cost");
            this.Property(t => t.Hourly_Cost).HasColumnName("Hourly Cost");
        }
    }
}
