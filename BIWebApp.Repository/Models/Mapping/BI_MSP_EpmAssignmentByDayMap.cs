using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BIWebApp.Data;

namespace BIWebApp.Repository.Models.Mapping
{
    public class BI_MSP_EpmAssignmentByDayMap : EntityTypeConfiguration<BI_MSP_EpmAssignmentByDay>
    {
        public BI_MSP_EpmAssignmentByDayMap()
        {
            // Primary Key
            this.HasKey(t => t.BILogID);

            // Properties
            this.Property(t => t.Status_Description)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProjectName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Project_Owner)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ResourceName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Customer_Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Job_Number)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.TaskName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("BI_MSP_EpmAssignmentByDay");
            this.Property(t => t.BILogID).HasColumnName("BILogID");
            this.Property(t => t.AssignmentUID).HasColumnName("AssignmentUID");
            this.Property(t => t.TimeByDay).HasColumnName("TimeByDay");
            this.Property(t => t.ProjectUID).HasColumnName("ProjectUID");
            this.Property(t => t.TaskUID).HasColumnName("TaskUID");
            this.Property(t => t.Date_Entered).HasColumnName("Date Entered");
            this.Property(t => t.Status_Code).HasColumnName("Status Code");
            this.Property(t => t.Status_Description).HasColumnName("Status Description");
            this.Property(t => t.AssignmentStartDate).HasColumnName("AssignmentStartDate");
            this.Property(t => t.AssignmentFinishDate).HasColumnName("AssignmentFinishDate");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.Project_Owner).HasColumnName("Project Owner");
            this.Property(t => t.ResourceUID).HasColumnName("ResourceUID");
            this.Property(t => t.ResourceName).HasColumnName("ResourceName");
            this.Property(t => t.Customer_Name).HasColumnName("Customer Name");
            this.Property(t => t.Job_Number).HasColumnName("Job Number");
            this.Property(t => t.TaskName).HasColumnName("TaskName");
        }
    }
}
