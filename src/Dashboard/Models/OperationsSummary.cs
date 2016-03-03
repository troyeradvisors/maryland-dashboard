using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class OperationsSummary
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int AdministrativeServiceAdjustedExpense { get; set; }
        public int AdministrativeServiceBookExpense { get; set; }
        public int BeforeIncomeTaxNetIncome { get; set; }
        public int CapitalOrPropertyServiceAdjusedExpense { get; set; }
        public int CapitalOrPropertyServiceBookExpense { get; set; }
        public int CapitalValueRentalAdjustedExpense { get; set; }
        public int CapitalValueRentalBookExpense { get; set; }
        public int GrossOperatingProfit { get; set; }
        public int IncomeTaxProvision { get; set; }
        public int LessAllowancesAndAdjustmentsRevenue { get; set; }
        public int NetRevenue { get; set; }
        public int NonOperatingRevenue { get; set; }
        public int NonReimbursableExpense { get; set; }
        public int NursingCareServiceAdjustedExpense { get; set; }
        public int NursingCareServiceBookExpense { get; set; }
        public int OtherPatientCareServiceAdjustedExpense { get; set; }
        public int OtherPatientCareServiceBookExpense { get; set; }
        public int PerFinancialStatementsNetIncome { get; set; }
        public int RoutineServiceBookExpense { get; set; }
        public int RoutineServiceRevenue { get; set; }
        public int RoutingServiceAdjustedExpense { get; set; }
        public int SpecialServiceRevenue { get; set; }
        public int TotalAdjustedOperatingExpense { get; set; }
        public int TotalBookOperatingExpense { get; set; }
    }
}
