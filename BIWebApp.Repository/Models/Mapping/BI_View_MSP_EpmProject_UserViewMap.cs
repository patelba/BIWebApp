using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BIWebApp.Data;

namespace BIWebApp.Repository.Models.Mapping
{
    public class BI_View_MSP_EpmProject_UserViewMap : EntityTypeConfiguration<BI_View_MSP_EpmProject_UserView>
    {
        public BI_View_MSP_EpmProject_UserViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProjectOwnerResourceUID, t.ProjectUID, t.ProjectName, t.ProjectType, t.ProjectWbsIsStale, t.ProjectEarnedValueIsStale, t.ProjectRollupsAreStale, t.ProjectHierarchyNotSynchronized, t.ProjectCalculationsAreStale, t.ProjectGhostTaskAreStale, t.ProjectCurrency, t.ProjectCreatedRevisionCounter, t.ProjectModifiedRevisionCounter, t.ProjectCreatedDate, t.ProjectModifiedDate, t.ProjectVisibilityMode, t.ProjectCount, t.Day_Rate });

            // Properties
            this.Property(t => t.ProjectName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ProjectAuthorName)
                .HasMaxLength(255);

            this.Property(t => t.ProjectManagerName)
                .HasMaxLength(255);

            this.Property(t => t.ProjectType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProjectWorkspaceInternalHRef)
                .HasMaxLength(1024);

            this.Property(t => t.ProjectCurrency)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ProjectCategoryName)
                .HasMaxLength(255);

            this.Property(t => t.ProjectCompanyName)
                .HasMaxLength(255);

            this.Property(t => t.ProjectKeywords)
                .HasMaxLength(255);

            this.Property(t => t.ProjectSubject)
                .HasMaxLength(255);

            this.Property(t => t.ProjectTitle)
                .HasMaxLength(255);

            this.Property(t => t.ProjectCreatedRevisionCounter)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProjectModifiedRevisionCounter)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProjectOwnerName)
                .HasMaxLength(255);

            this.Property(t => t.ProjectCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Project_Departments)
                .HasMaxLength(4000);

            this.Property(t => t.Job_Number)
                .HasMaxLength(4000);

            this.Property(t => t.Portfolio_Manager)
                .HasMaxLength(4000);

            this.Property(t => t.Programme_Manager)
                .HasMaxLength(4000);

            this.Property(t => t.Customer_Name)
                .HasMaxLength(4000);

            this.Property(t => t.Project_Status)
                .HasMaxLength(4000);

            this.Property(t => t.Cost_Centre)
                .HasMaxLength(4000);

            this.Property(t => t.Plan_Type)
                .HasMaxLength(4000);

            this.Property(t => t.Chargeable_Project)
                .HasMaxLength(4000);

            this.Property(t => t.Day_Rate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BI_View_MSP_EpmProject_UserView");
            this.Property(t => t.ProjectOwnerResourceUID).HasColumnName("ProjectOwnerResourceUID");
            this.Property(t => t.ProjectUID).HasColumnName("ProjectUID");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.ProjectDescription).HasColumnName("ProjectDescription");
            this.Property(t => t.ProjectAuthorName).HasColumnName("ProjectAuthorName");
            this.Property(t => t.EnterpriseProjectTypeUID).HasColumnName("EnterpriseProjectTypeUID");
            this.Property(t => t.ProjectStartDate).HasColumnName("ProjectStartDate");
            this.Property(t => t.ProjectFinishDate).HasColumnName("ProjectFinishDate");
            this.Property(t => t.ProjectStatusDate).HasColumnName("ProjectStatusDate");
            this.Property(t => t.ProjectManagerName).HasColumnName("ProjectManagerName");
            this.Property(t => t.ProjectType).HasColumnName("ProjectType");
            this.Property(t => t.ProjectWorkspaceInternalHRef).HasColumnName("ProjectWorkspaceInternalHRef");
            this.Property(t => t.ProjectWbsIsStale).HasColumnName("ProjectWbsIsStale");
            this.Property(t => t.ProjectEarnedValueIsStale).HasColumnName("ProjectEarnedValueIsStale");
            this.Property(t => t.ProjectRollupsAreStale).HasColumnName("ProjectRollupsAreStale");
            this.Property(t => t.ProjectHierarchyNotSynchronized).HasColumnName("ProjectHierarchyNotSynchronized");
            this.Property(t => t.ProjectCalculationsAreStale).HasColumnName("ProjectCalculationsAreStale");
            this.Property(t => t.ProjectGhostTaskAreStale).HasColumnName("ProjectGhostTaskAreStale");
            this.Property(t => t.ProjectCurrency).HasColumnName("ProjectCurrency");
            this.Property(t => t.ProjectCategoryName).HasColumnName("ProjectCategoryName");
            this.Property(t => t.ProjectCompanyName).HasColumnName("ProjectCompanyName");
            this.Property(t => t.ProjectKeywords).HasColumnName("ProjectKeywords");
            this.Property(t => t.ProjectSubject).HasColumnName("ProjectSubject");
            this.Property(t => t.ProjectTitle).HasColumnName("ProjectTitle");
            this.Property(t => t.ResourcePlanUtilizationType).HasColumnName("ResourcePlanUtilizationType");
            this.Property(t => t.ResourcePlanUtilizationDate).HasColumnName("ResourcePlanUtilizationDate");
            this.Property(t => t.ProjectCreatedRevisionCounter).HasColumnName("ProjectCreatedRevisionCounter");
            this.Property(t => t.ProjectModifiedRevisionCounter).HasColumnName("ProjectModifiedRevisionCounter");
            this.Property(t => t.ProjectCreatedDate).HasColumnName("ProjectCreatedDate");
            this.Property(t => t.ProjectModifiedDate).HasColumnName("ProjectModifiedDate");
            this.Property(t => t.ProjectCalendarDuration).HasColumnName("ProjectCalendarDuration");
            this.Property(t => t.ProjectVisibilityMode).HasColumnName("ProjectVisibilityMode");
            this.Property(t => t.ParentProjectUID).HasColumnName("ParentProjectUID");
            this.Property(t => t.ProjectFixedCost).HasColumnName("ProjectFixedCost");
            this.Property(t => t.ProjectCost).HasColumnName("ProjectCost");
            this.Property(t => t.ProjectOvertimeCost).HasColumnName("ProjectOvertimeCost");
            this.Property(t => t.ProjectActualCost).HasColumnName("ProjectActualCost");
            this.Property(t => t.ProjectActualOvertimeCost).HasColumnName("ProjectActualOvertimeCost");
            this.Property(t => t.ProjectWork).HasColumnName("ProjectWork");
            this.Property(t => t.ProjectOvertimeWork).HasColumnName("ProjectOvertimeWork");
            this.Property(t => t.ProjectActualWork).HasColumnName("ProjectActualWork");
            this.Property(t => t.ProjectActualOvertimeWork).HasColumnName("ProjectActualOvertimeWork");
            this.Property(t => t.ProjectDurationVariance).HasColumnName("ProjectDurationVariance");
            this.Property(t => t.ProjectStartVariance).HasColumnName("ProjectStartVariance");
            this.Property(t => t.ProjectFinishVariance).HasColumnName("ProjectFinishVariance");
            this.Property(t => t.ProjectDuration).HasColumnName("ProjectDuration");
            this.Property(t => t.ProjectActualDuration).HasColumnName("ProjectActualDuration");
            this.Property(t => t.ProjectActualStartDate).HasColumnName("ProjectActualStartDate");
            this.Property(t => t.ProjectActualFinishDate).HasColumnName("ProjectActualFinishDate");
            this.Property(t => t.ProjectPercentCompleted).HasColumnName("ProjectPercentCompleted");
            this.Property(t => t.ProjectPercentWorkCompleted).HasColumnName("ProjectPercentWorkCompleted");
            this.Property(t => t.ProjectACWP).HasColumnName("ProjectACWP");
            this.Property(t => t.ProjectBCWP).HasColumnName("ProjectBCWP");
            this.Property(t => t.ProjectBCWS).HasColumnName("ProjectBCWS");
            this.Property(t => t.ProjectSPI).HasColumnName("ProjectSPI");
            this.Property(t => t.ProjectTCPI).HasColumnName("ProjectTCPI");
            this.Property(t => t.ProjectVAC).HasColumnName("ProjectVAC");
            this.Property(t => t.ProjectEAC).HasColumnName("ProjectEAC");
            this.Property(t => t.ProjectCostVariance).HasColumnName("ProjectCostVariance");
            this.Property(t => t.ProjectCV).HasColumnName("ProjectCV");
            this.Property(t => t.ProjectCPI).HasColumnName("ProjectCPI");
            this.Property(t => t.ProjectEarlyFinish).HasColumnName("ProjectEarlyFinish");
            this.Property(t => t.ProjectEarlyStart).HasColumnName("ProjectEarlyStart");
            this.Property(t => t.ProjectLateFinish).HasColumnName("ProjectLateFinish");
            this.Property(t => t.ProjectLateStart).HasColumnName("ProjectLateStart");
            this.Property(t => t.ProjectSV).HasColumnName("ProjectSV");
            this.Property(t => t.ProjectWorkVariance).HasColumnName("ProjectWorkVariance");
            this.Property(t => t.ProjectBudgetCost).HasColumnName("ProjectBudgetCost");
            this.Property(t => t.ProjectBudgetWork).HasColumnName("ProjectBudgetWork");
            this.Property(t => t.ProjectResourcePlanWork).HasColumnName("ProjectResourcePlanWork");
            this.Property(t => t.ProjectRegularCost).HasColumnName("ProjectRegularCost");
            this.Property(t => t.ProjectRemainingCost).HasColumnName("ProjectRemainingCost");
            this.Property(t => t.ProjectRemainingOvertimeCost).HasColumnName("ProjectRemainingOvertimeCost");
            this.Property(t => t.ProjectActualRegularCost).HasColumnName("ProjectActualRegularCost");
            this.Property(t => t.ProjectRemainingRegularCost).HasColumnName("ProjectRemainingRegularCost");
            this.Property(t => t.ProjectRegularWork).HasColumnName("ProjectRegularWork");
            this.Property(t => t.ProjectRemainingWork).HasColumnName("ProjectRemainingWork");
            this.Property(t => t.ProjectRemainingOvertimeWork).HasColumnName("ProjectRemainingOvertimeWork");
            this.Property(t => t.ProjectActualRegularWork).HasColumnName("ProjectActualRegularWork");
            this.Property(t => t.ProjectRemainingRegularWork).HasColumnName("ProjectRemainingRegularWork");
            this.Property(t => t.ProjectRemainingDuration).HasColumnName("ProjectRemainingDuration");
            this.Property(t => t.ProjectCVP).HasColumnName("ProjectCVP");
            this.Property(t => t.ProjectSVP).HasColumnName("ProjectSVP");
            this.Property(t => t.ProjectOwnerName).HasColumnName("ProjectOwnerName");
            this.Property(t => t.ProjectCount).HasColumnName("ProjectCount");
            this.Property(t => t.ProjectBaseline0Cost).HasColumnName("ProjectBaseline0Cost");
            this.Property(t => t.ProjectBaseline0FixedCost).HasColumnName("ProjectBaseline0FixedCost");
            this.Property(t => t.ProjectBaseline0Work).HasColumnName("ProjectBaseline0Work");
            this.Property(t => t.ProjectBaseline0BudgetCost).HasColumnName("ProjectBaseline0BudgetCost");
            this.Property(t => t.ProjectBaseline0BudgetWork).HasColumnName("ProjectBaseline0BudgetWork");
            this.Property(t => t.ProjectBaseline0StartDate).HasColumnName("ProjectBaseline0StartDate");
            this.Property(t => t.ProjectBaseline0FinishDate).HasColumnName("ProjectBaseline0FinishDate");
            this.Property(t => t.ProjectBaseline0Duration).HasColumnName("ProjectBaseline0Duration");
            this.Property(t => t.ProjectBaseline1Cost).HasColumnName("ProjectBaseline1Cost");
            this.Property(t => t.ProjectBaseline1FixedCost).HasColumnName("ProjectBaseline1FixedCost");
            this.Property(t => t.ProjectBaseline1Work).HasColumnName("ProjectBaseline1Work");
            this.Property(t => t.ProjectBaseline1BudgetCost).HasColumnName("ProjectBaseline1BudgetCost");
            this.Property(t => t.ProjectBaseline1BudgetWork).HasColumnName("ProjectBaseline1BudgetWork");
            this.Property(t => t.ProjectBaseline1StartDate).HasColumnName("ProjectBaseline1StartDate");
            this.Property(t => t.ProjectBaseline1FinishDate).HasColumnName("ProjectBaseline1FinishDate");
            this.Property(t => t.ProjectBaseline1Duration).HasColumnName("ProjectBaseline1Duration");
            this.Property(t => t.ProjectBaseline2Cost).HasColumnName("ProjectBaseline2Cost");
            this.Property(t => t.ProjectBaseline2FixedCost).HasColumnName("ProjectBaseline2FixedCost");
            this.Property(t => t.ProjectBaseline2Work).HasColumnName("ProjectBaseline2Work");
            this.Property(t => t.ProjectBaseline2BudgetCost).HasColumnName("ProjectBaseline2BudgetCost");
            this.Property(t => t.ProjectBaseline2BudgetWork).HasColumnName("ProjectBaseline2BudgetWork");
            this.Property(t => t.ProjectBaseline2StartDate).HasColumnName("ProjectBaseline2StartDate");
            this.Property(t => t.ProjectBaseline2FinishDate).HasColumnName("ProjectBaseline2FinishDate");
            this.Property(t => t.ProjectBaseline2Duration).HasColumnName("ProjectBaseline2Duration");
            this.Property(t => t.ProjectBaseline3Cost).HasColumnName("ProjectBaseline3Cost");
            this.Property(t => t.ProjectBaseline3FixedCost).HasColumnName("ProjectBaseline3FixedCost");
            this.Property(t => t.ProjectBaseline3Work).HasColumnName("ProjectBaseline3Work");
            this.Property(t => t.ProjectBaseline3BudgetCost).HasColumnName("ProjectBaseline3BudgetCost");
            this.Property(t => t.ProjectBaseline3BudgetWork).HasColumnName("ProjectBaseline3BudgetWork");
            this.Property(t => t.ProjectBaseline3StartDate).HasColumnName("ProjectBaseline3StartDate");
            this.Property(t => t.ProjectBaseline3FinishDate).HasColumnName("ProjectBaseline3FinishDate");
            this.Property(t => t.ProjectBaseline3Duration).HasColumnName("ProjectBaseline3Duration");
            this.Property(t => t.ProjectBaseline4Cost).HasColumnName("ProjectBaseline4Cost");
            this.Property(t => t.ProjectBaseline4FixedCost).HasColumnName("ProjectBaseline4FixedCost");
            this.Property(t => t.ProjectBaseline4Work).HasColumnName("ProjectBaseline4Work");
            this.Property(t => t.ProjectBaseline4BudgetCost).HasColumnName("ProjectBaseline4BudgetCost");
            this.Property(t => t.ProjectBaseline4BudgetWork).HasColumnName("ProjectBaseline4BudgetWork");
            this.Property(t => t.ProjectBaseline4StartDate).HasColumnName("ProjectBaseline4StartDate");
            this.Property(t => t.ProjectBaseline4FinishDate).HasColumnName("ProjectBaseline4FinishDate");
            this.Property(t => t.ProjectBaseline4Duration).HasColumnName("ProjectBaseline4Duration");
            this.Property(t => t.ProjectBaseline5Cost).HasColumnName("ProjectBaseline5Cost");
            this.Property(t => t.ProjectBaseline5FixedCost).HasColumnName("ProjectBaseline5FixedCost");
            this.Property(t => t.ProjectBaseline5Work).HasColumnName("ProjectBaseline5Work");
            this.Property(t => t.ProjectBaseline5BudgetCost).HasColumnName("ProjectBaseline5BudgetCost");
            this.Property(t => t.ProjectBaseline5BudgetWork).HasColumnName("ProjectBaseline5BudgetWork");
            this.Property(t => t.ProjectBaseline5StartDate).HasColumnName("ProjectBaseline5StartDate");
            this.Property(t => t.ProjectBaseline5FinishDate).HasColumnName("ProjectBaseline5FinishDate");
            this.Property(t => t.ProjectBaseline5Duration).HasColumnName("ProjectBaseline5Duration");
            this.Property(t => t.ProjectBaseline6Cost).HasColumnName("ProjectBaseline6Cost");
            this.Property(t => t.ProjectBaseline6FixedCost).HasColumnName("ProjectBaseline6FixedCost");
            this.Property(t => t.ProjectBaseline6Work).HasColumnName("ProjectBaseline6Work");
            this.Property(t => t.ProjectBaseline6BudgetCost).HasColumnName("ProjectBaseline6BudgetCost");
            this.Property(t => t.ProjectBaseline6BudgetWork).HasColumnName("ProjectBaseline6BudgetWork");
            this.Property(t => t.ProjectBaseline6StartDate).HasColumnName("ProjectBaseline6StartDate");
            this.Property(t => t.ProjectBaseline6FinishDate).HasColumnName("ProjectBaseline6FinishDate");
            this.Property(t => t.ProjectBaseline6Duration).HasColumnName("ProjectBaseline6Duration");
            this.Property(t => t.ProjectBaseline7Cost).HasColumnName("ProjectBaseline7Cost");
            this.Property(t => t.ProjectBaseline7FixedCost).HasColumnName("ProjectBaseline7FixedCost");
            this.Property(t => t.ProjectBaseline7Work).HasColumnName("ProjectBaseline7Work");
            this.Property(t => t.ProjectBaseline7BudgetCost).HasColumnName("ProjectBaseline7BudgetCost");
            this.Property(t => t.ProjectBaseline7BudgetWork).HasColumnName("ProjectBaseline7BudgetWork");
            this.Property(t => t.ProjectBaseline7StartDate).HasColumnName("ProjectBaseline7StartDate");
            this.Property(t => t.ProjectBaseline7FinishDate).HasColumnName("ProjectBaseline7FinishDate");
            this.Property(t => t.ProjectBaseline7Duration).HasColumnName("ProjectBaseline7Duration");
            this.Property(t => t.ProjectBaseline8Cost).HasColumnName("ProjectBaseline8Cost");
            this.Property(t => t.ProjectBaseline8FixedCost).HasColumnName("ProjectBaseline8FixedCost");
            this.Property(t => t.ProjectBaseline8Work).HasColumnName("ProjectBaseline8Work");
            this.Property(t => t.ProjectBaseline8BudgetCost).HasColumnName("ProjectBaseline8BudgetCost");
            this.Property(t => t.ProjectBaseline8BudgetWork).HasColumnName("ProjectBaseline8BudgetWork");
            this.Property(t => t.ProjectBaseline8StartDate).HasColumnName("ProjectBaseline8StartDate");
            this.Property(t => t.ProjectBaseline8FinishDate).HasColumnName("ProjectBaseline8FinishDate");
            this.Property(t => t.ProjectBaseline8Duration).HasColumnName("ProjectBaseline8Duration");
            this.Property(t => t.ProjectBaseline9Cost).HasColumnName("ProjectBaseline9Cost");
            this.Property(t => t.ProjectBaseline9FixedCost).HasColumnName("ProjectBaseline9FixedCost");
            this.Property(t => t.ProjectBaseline9Work).HasColumnName("ProjectBaseline9Work");
            this.Property(t => t.ProjectBaseline9BudgetCost).HasColumnName("ProjectBaseline9BudgetCost");
            this.Property(t => t.ProjectBaseline9BudgetWork).HasColumnName("ProjectBaseline9BudgetWork");
            this.Property(t => t.ProjectBaseline9StartDate).HasColumnName("ProjectBaseline9StartDate");
            this.Property(t => t.ProjectBaseline9FinishDate).HasColumnName("ProjectBaseline9FinishDate");
            this.Property(t => t.ProjectBaseline9Duration).HasColumnName("ProjectBaseline9Duration");
            this.Property(t => t.ProjectBaseline10Cost).HasColumnName("ProjectBaseline10Cost");
            this.Property(t => t.ProjectBaseline10FixedCost).HasColumnName("ProjectBaseline10FixedCost");
            this.Property(t => t.ProjectBaseline10Work).HasColumnName("ProjectBaseline10Work");
            this.Property(t => t.ProjectBaseline10BudgetCost).HasColumnName("ProjectBaseline10BudgetCost");
            this.Property(t => t.ProjectBaseline10BudgetWork).HasColumnName("ProjectBaseline10BudgetWork");
            this.Property(t => t.ProjectBaseline10StartDate).HasColumnName("ProjectBaseline10StartDate");
            this.Property(t => t.ProjectBaseline10FinishDate).HasColumnName("ProjectBaseline10FinishDate");
            this.Property(t => t.ProjectBaseline10Duration).HasColumnName("ProjectBaseline10Duration");
            this.Property(t => t.Project_Departments).HasColumnName("Project Departments");
            this.Property(t => t.Job_Number).HasColumnName("Job Number");
            this.Property(t => t.Portfolio_Manager).HasColumnName("Portfolio Manager");
            this.Property(t => t.Programme_Manager).HasColumnName("Programme Manager");
            this.Property(t => t.Customer_Name).HasColumnName("Customer Name");
            this.Property(t => t.Project_Status).HasColumnName("Project Status");
            this.Property(t => t.Cost_Centre).HasColumnName("Cost Centre");
            this.Property(t => t.Plan_Type).HasColumnName("Plan Type");
            this.Property(t => t.Chargeable_Project).HasColumnName("Chargeable Project");
            this.Property(t => t.Day_Rate).HasColumnName("Day Rate");
            this.Property(t => t.Cost_Rate).HasColumnName("Cost Rate");
        }
    }
}
