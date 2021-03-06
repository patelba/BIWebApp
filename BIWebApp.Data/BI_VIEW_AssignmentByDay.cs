using System;
using System.Collections.Generic;

namespace BIWebApp.Data
{
    public partial class BI_VIEW_AssignmentByDay : BaseEntity
    {
        public Nullable<System.Guid> AssignmentUID { get; set; }
        public Nullable<System.DateTime> TimeByDay { get; set; }
        public Nullable<System.Guid> ProjectUID { get; set; }
        public Nullable<System.Guid> TaskUID { get; set; }
        public decimal AssignmentCost { get; set; }
        public decimal AssignmentOvertimeCost { get; set; }
        public decimal AssignmentActualCost { get; set; }
        public decimal AssignmentActualOvertimeCost { get; set; }
        public decimal AssignmentWork { get; set; }
        public decimal AssignmentOvertimeWork { get; set; }
        public decimal AssignmentActualWork { get; set; }
        public decimal AssignmentActualOvertimeWork { get; set; }
        public decimal AssignmentMaterialWork { get; set; }
        public decimal AssignmentMaterialActualWork { get; set; }
        public decimal AssignmentBudgetCost { get; set; }
        public decimal AssignmentBudgetWork { get; set; }
        public decimal AssignmentBudgetMaterialWork { get; set; }
        public decimal AssignmentResourcePlanWork { get; set; }
        public decimal AssignmentRegularCost { get; set; }
        public decimal AssignmentRemainingCost { get; set; }
        public decimal AssignmentRemainingOvertimeCost { get; set; }
        public decimal AssignmentActualRegularCost { get; set; }
        public decimal AssignmentRemainingRegularCost { get; set; }
        public decimal AssignmentRegularWork { get; set; }
        public decimal AssignmentRemainingWork { get; set; }
        public decimal AssignmentRemainingOvertimeWork { get; set; }
        public decimal AssignmentActualRegularWork { get; set; }
        public decimal AssignmentRemainingRegularWork { get; set; }
        public Nullable<decimal> AssignmentCombinedWork { get; set; }
        public System.Guid ResourceUID { get; set; }
        public System.Guid ResourceOwnerUID { get; set; }
        public Nullable<decimal> AssignmentBaseline0Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline0Work { get; set; }
        public Nullable<decimal> AssignmentBaseline0MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline0BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline0BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline0BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline1Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline1Work { get; set; }
        public Nullable<decimal> AssignmentBaseline1MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline1BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline1BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline1BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline2Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline2Work { get; set; }
        public Nullable<decimal> AssignmentBaseline2MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline2BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline2BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline2BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline3Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline3Work { get; set; }
        public Nullable<decimal> AssignmentBaseline3MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline3BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline3BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline3BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline4Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline4Work { get; set; }
        public Nullable<decimal> AssignmentBaseline4MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline4BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline4BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline4BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline5Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline5Work { get; set; }
        public Nullable<decimal> AssignmentBaseline5MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline5BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline5BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline5BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline6Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline6Work { get; set; }
        public Nullable<decimal> AssignmentBaseline6MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline6BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline6BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline6BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline7Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline7Work { get; set; }
        public Nullable<decimal> AssignmentBaseline7MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline7BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline7BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline7BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline8Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline8Work { get; set; }
        public Nullable<decimal> AssignmentBaseline8MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline8BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline8BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline8BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline9Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline9Work { get; set; }
        public Nullable<decimal> AssignmentBaseline9MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline9BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline9BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline9BudgetMaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline10Cost { get; set; }
        public Nullable<decimal> AssignmentBaseline10Work { get; set; }
        public Nullable<decimal> AssignmentBaseline10MaterialWork { get; set; }
        public Nullable<decimal> AssignmentBaseline10BudgetCost { get; set; }
        public Nullable<decimal> AssignmentBaseline10BudgetWork { get; set; }
        public Nullable<decimal> AssignmentBaseline10BudgetMaterialWork { get; set; }
        public decimal ResourceStandardRate { get; set; }
        public Nullable<decimal> K3_Cost { get; set; }
        public Nullable<decimal> Cost_Rate { get; set; }
        public Nullable<decimal> K3_Revenue { get; set; }
        public Nullable<decimal> K3_StandardCost { get; set; }
    }
}
