using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BIWebApp.Data;

namespace BIWebApp.Repository.Models.Mapping
{
    public class BI_VIEW_AssignmentByDayMap : EntityTypeConfiguration<BI_VIEW_AssignmentByDay>
    {
        public BI_VIEW_AssignmentByDayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AssignmentCost, t.AssignmentOvertimeCost, t.AssignmentActualCost, t.AssignmentActualOvertimeCost, t.AssignmentWork, t.AssignmentOvertimeWork, t.AssignmentActualWork, t.AssignmentActualOvertimeWork, t.AssignmentMaterialWork, t.AssignmentMaterialActualWork, t.AssignmentBudgetCost, t.AssignmentBudgetWork, t.AssignmentBudgetMaterialWork, t.AssignmentResourcePlanWork, t.AssignmentRegularCost, t.AssignmentRemainingCost, t.AssignmentRemainingOvertimeCost, t.AssignmentActualRegularCost, t.AssignmentRemainingRegularCost, t.AssignmentRegularWork, t.AssignmentRemainingWork, t.AssignmentRemainingOvertimeWork, t.AssignmentActualRegularWork, t.AssignmentRemainingRegularWork, t.ResourceUID, t.ResourceOwnerUID, t.ResourceStandardRate });

            // Properties
            this.Property(t => t.AssignmentCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentOvertimeCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentActualCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentActualOvertimeCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentOvertimeWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentActualWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentActualOvertimeWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentMaterialWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentMaterialActualWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentBudgetCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentBudgetWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentBudgetMaterialWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentResourcePlanWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentRegularCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentRemainingCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentRemainingOvertimeCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentActualRegularCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentRemainingRegularCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentRegularWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentRemainingWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentRemainingOvertimeWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentActualRegularWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentRemainingRegularWork)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ResourceStandardRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BI_VIEW_AssignmentByDay");
            this.Property(t => t.AssignmentUID).HasColumnName("AssignmentUID");
            this.Property(t => t.TimeByDay).HasColumnName("TimeByDay");
            this.Property(t => t.ProjectUID).HasColumnName("ProjectUID");
            this.Property(t => t.TaskUID).HasColumnName("TaskUID");
            this.Property(t => t.AssignmentCost).HasColumnName("AssignmentCost");
            this.Property(t => t.AssignmentOvertimeCost).HasColumnName("AssignmentOvertimeCost");
            this.Property(t => t.AssignmentActualCost).HasColumnName("AssignmentActualCost");
            this.Property(t => t.AssignmentActualOvertimeCost).HasColumnName("AssignmentActualOvertimeCost");
            this.Property(t => t.AssignmentWork).HasColumnName("AssignmentWork");
            this.Property(t => t.AssignmentOvertimeWork).HasColumnName("AssignmentOvertimeWork");
            this.Property(t => t.AssignmentActualWork).HasColumnName("AssignmentActualWork");
            this.Property(t => t.AssignmentActualOvertimeWork).HasColumnName("AssignmentActualOvertimeWork");
            this.Property(t => t.AssignmentMaterialWork).HasColumnName("AssignmentMaterialWork");
            this.Property(t => t.AssignmentMaterialActualWork).HasColumnName("AssignmentMaterialActualWork");
            this.Property(t => t.AssignmentBudgetCost).HasColumnName("AssignmentBudgetCost");
            this.Property(t => t.AssignmentBudgetWork).HasColumnName("AssignmentBudgetWork");
            this.Property(t => t.AssignmentBudgetMaterialWork).HasColumnName("AssignmentBudgetMaterialWork");
            this.Property(t => t.AssignmentResourcePlanWork).HasColumnName("AssignmentResourcePlanWork");
            this.Property(t => t.AssignmentRegularCost).HasColumnName("AssignmentRegularCost");
            this.Property(t => t.AssignmentRemainingCost).HasColumnName("AssignmentRemainingCost");
            this.Property(t => t.AssignmentRemainingOvertimeCost).HasColumnName("AssignmentRemainingOvertimeCost");
            this.Property(t => t.AssignmentActualRegularCost).HasColumnName("AssignmentActualRegularCost");
            this.Property(t => t.AssignmentRemainingRegularCost).HasColumnName("AssignmentRemainingRegularCost");
            this.Property(t => t.AssignmentRegularWork).HasColumnName("AssignmentRegularWork");
            this.Property(t => t.AssignmentRemainingWork).HasColumnName("AssignmentRemainingWork");
            this.Property(t => t.AssignmentRemainingOvertimeWork).HasColumnName("AssignmentRemainingOvertimeWork");
            this.Property(t => t.AssignmentActualRegularWork).HasColumnName("AssignmentActualRegularWork");
            this.Property(t => t.AssignmentRemainingRegularWork).HasColumnName("AssignmentRemainingRegularWork");
            this.Property(t => t.AssignmentCombinedWork).HasColumnName("AssignmentCombinedWork");
            this.Property(t => t.ResourceUID).HasColumnName("ResourceUID");
            this.Property(t => t.ResourceOwnerUID).HasColumnName("ResourceOwnerUID");
            this.Property(t => t.AssignmentBaseline0Cost).HasColumnName("AssignmentBaseline0Cost");
            this.Property(t => t.AssignmentBaseline0Work).HasColumnName("AssignmentBaseline0Work");
            this.Property(t => t.AssignmentBaseline0MaterialWork).HasColumnName("AssignmentBaseline0MaterialWork");
            this.Property(t => t.AssignmentBaseline0BudgetCost).HasColumnName("AssignmentBaseline0BudgetCost");
            this.Property(t => t.AssignmentBaseline0BudgetWork).HasColumnName("AssignmentBaseline0BudgetWork");
            this.Property(t => t.AssignmentBaseline0BudgetMaterialWork).HasColumnName("AssignmentBaseline0BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline1Cost).HasColumnName("AssignmentBaseline1Cost");
            this.Property(t => t.AssignmentBaseline1Work).HasColumnName("AssignmentBaseline1Work");
            this.Property(t => t.AssignmentBaseline1MaterialWork).HasColumnName("AssignmentBaseline1MaterialWork");
            this.Property(t => t.AssignmentBaseline1BudgetCost).HasColumnName("AssignmentBaseline1BudgetCost");
            this.Property(t => t.AssignmentBaseline1BudgetWork).HasColumnName("AssignmentBaseline1BudgetWork");
            this.Property(t => t.AssignmentBaseline1BudgetMaterialWork).HasColumnName("AssignmentBaseline1BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline2Cost).HasColumnName("AssignmentBaseline2Cost");
            this.Property(t => t.AssignmentBaseline2Work).HasColumnName("AssignmentBaseline2Work");
            this.Property(t => t.AssignmentBaseline2MaterialWork).HasColumnName("AssignmentBaseline2MaterialWork");
            this.Property(t => t.AssignmentBaseline2BudgetCost).HasColumnName("AssignmentBaseline2BudgetCost");
            this.Property(t => t.AssignmentBaseline2BudgetWork).HasColumnName("AssignmentBaseline2BudgetWork");
            this.Property(t => t.AssignmentBaseline2BudgetMaterialWork).HasColumnName("AssignmentBaseline2BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline3Cost).HasColumnName("AssignmentBaseline3Cost");
            this.Property(t => t.AssignmentBaseline3Work).HasColumnName("AssignmentBaseline3Work");
            this.Property(t => t.AssignmentBaseline3MaterialWork).HasColumnName("AssignmentBaseline3MaterialWork");
            this.Property(t => t.AssignmentBaseline3BudgetCost).HasColumnName("AssignmentBaseline3BudgetCost");
            this.Property(t => t.AssignmentBaseline3BudgetWork).HasColumnName("AssignmentBaseline3BudgetWork");
            this.Property(t => t.AssignmentBaseline3BudgetMaterialWork).HasColumnName("AssignmentBaseline3BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline4Cost).HasColumnName("AssignmentBaseline4Cost");
            this.Property(t => t.AssignmentBaseline4Work).HasColumnName("AssignmentBaseline4Work");
            this.Property(t => t.AssignmentBaseline4MaterialWork).HasColumnName("AssignmentBaseline4MaterialWork");
            this.Property(t => t.AssignmentBaseline4BudgetCost).HasColumnName("AssignmentBaseline4BudgetCost");
            this.Property(t => t.AssignmentBaseline4BudgetWork).HasColumnName("AssignmentBaseline4BudgetWork");
            this.Property(t => t.AssignmentBaseline4BudgetMaterialWork).HasColumnName("AssignmentBaseline4BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline5Cost).HasColumnName("AssignmentBaseline5Cost");
            this.Property(t => t.AssignmentBaseline5Work).HasColumnName("AssignmentBaseline5Work");
            this.Property(t => t.AssignmentBaseline5MaterialWork).HasColumnName("AssignmentBaseline5MaterialWork");
            this.Property(t => t.AssignmentBaseline5BudgetCost).HasColumnName("AssignmentBaseline5BudgetCost");
            this.Property(t => t.AssignmentBaseline5BudgetWork).HasColumnName("AssignmentBaseline5BudgetWork");
            this.Property(t => t.AssignmentBaseline5BudgetMaterialWork).HasColumnName("AssignmentBaseline5BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline6Cost).HasColumnName("AssignmentBaseline6Cost");
            this.Property(t => t.AssignmentBaseline6Work).HasColumnName("AssignmentBaseline6Work");
            this.Property(t => t.AssignmentBaseline6MaterialWork).HasColumnName("AssignmentBaseline6MaterialWork");
            this.Property(t => t.AssignmentBaseline6BudgetCost).HasColumnName("AssignmentBaseline6BudgetCost");
            this.Property(t => t.AssignmentBaseline6BudgetWork).HasColumnName("AssignmentBaseline6BudgetWork");
            this.Property(t => t.AssignmentBaseline6BudgetMaterialWork).HasColumnName("AssignmentBaseline6BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline7Cost).HasColumnName("AssignmentBaseline7Cost");
            this.Property(t => t.AssignmentBaseline7Work).HasColumnName("AssignmentBaseline7Work");
            this.Property(t => t.AssignmentBaseline7MaterialWork).HasColumnName("AssignmentBaseline7MaterialWork");
            this.Property(t => t.AssignmentBaseline7BudgetCost).HasColumnName("AssignmentBaseline7BudgetCost");
            this.Property(t => t.AssignmentBaseline7BudgetWork).HasColumnName("AssignmentBaseline7BudgetWork");
            this.Property(t => t.AssignmentBaseline7BudgetMaterialWork).HasColumnName("AssignmentBaseline7BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline8Cost).HasColumnName("AssignmentBaseline8Cost");
            this.Property(t => t.AssignmentBaseline8Work).HasColumnName("AssignmentBaseline8Work");
            this.Property(t => t.AssignmentBaseline8MaterialWork).HasColumnName("AssignmentBaseline8MaterialWork");
            this.Property(t => t.AssignmentBaseline8BudgetCost).HasColumnName("AssignmentBaseline8BudgetCost");
            this.Property(t => t.AssignmentBaseline8BudgetWork).HasColumnName("AssignmentBaseline8BudgetWork");
            this.Property(t => t.AssignmentBaseline8BudgetMaterialWork).HasColumnName("AssignmentBaseline8BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline9Cost).HasColumnName("AssignmentBaseline9Cost");
            this.Property(t => t.AssignmentBaseline9Work).HasColumnName("AssignmentBaseline9Work");
            this.Property(t => t.AssignmentBaseline9MaterialWork).HasColumnName("AssignmentBaseline9MaterialWork");
            this.Property(t => t.AssignmentBaseline9BudgetCost).HasColumnName("AssignmentBaseline9BudgetCost");
            this.Property(t => t.AssignmentBaseline9BudgetWork).HasColumnName("AssignmentBaseline9BudgetWork");
            this.Property(t => t.AssignmentBaseline9BudgetMaterialWork).HasColumnName("AssignmentBaseline9BudgetMaterialWork");
            this.Property(t => t.AssignmentBaseline10Cost).HasColumnName("AssignmentBaseline10Cost");
            this.Property(t => t.AssignmentBaseline10Work).HasColumnName("AssignmentBaseline10Work");
            this.Property(t => t.AssignmentBaseline10MaterialWork).HasColumnName("AssignmentBaseline10MaterialWork");
            this.Property(t => t.AssignmentBaseline10BudgetCost).HasColumnName("AssignmentBaseline10BudgetCost");
            this.Property(t => t.AssignmentBaseline10BudgetWork).HasColumnName("AssignmentBaseline10BudgetWork");
            this.Property(t => t.AssignmentBaseline10BudgetMaterialWork).HasColumnName("AssignmentBaseline10BudgetMaterialWork");
            this.Property(t => t.ResourceStandardRate).HasColumnName("ResourceStandardRate");
            this.Property(t => t.K3_Cost).HasColumnName("K3_Cost");
            this.Property(t => t.Cost_Rate).HasColumnName("Cost Rate");
            this.Property(t => t.K3_Revenue).HasColumnName("K3_Revenue");
            this.Property(t => t.K3_StandardCost).HasColumnName("K3_StandardCost");
        }
    }
}
