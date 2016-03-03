using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Models
{
    public class Summary
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int OperatingDays { get; set; }
        public int? CertifiedBedCount { get; set; }
        public int SpecialServiceRevenue { get; set; }
        public string ComprehensivePayor1Name { get; set; }
        public string ComprehensivePayor2Name { get; set; }
        public string ComprehensivePayor3Name { get; set; }
        public int PrivateDays { get; set; }
        public int MedicareDays { get; set; }
        public int MedicaidDays { get; set; }
        public int ComprehensivePayor1Days { get; set; }
        public int ComprehensivePayor2Days { get; set; }
        public int ComprehensivePayor3Days { get; set; }
        public int? OtherComprehensiveDays { get; set; }
        public int? ComprehensiveDays { get; set; }
        public int? OtherCareDays { get; set; }
        public int? TotalDays { get; set; }
        public int PrivateRevenue { get; set; }
        public int? UnadjustedMedicareRevenue { get; set; }
        public int? MedicaidRevenue { get; set; }
        public int ComprehensiveCareCustom1InsuranceDays { get; set; }
        public int ComprehensiveCareCustom2InsuranceDays { get; set; }
        public int ComprehensiveCareCustom3InsuranceDays { get; set; }
        public int UnadjustedComprehensivePayor1Revenue { get; set; }
        public int UnadjustedComprehensivePayor2Revenue { get; set; }
        public int UnadjustedComprehensivePayor3Revenue { get; set; }
        public int? UnadjustedOtherComprehensiveRevenue { get; set; }
        public int? ComprehensiveRevenue { get; set; }
        public int? OtherRevenue { get; set; }
        public int? GovernmentAndAdministrativeExpense { get; set; }
        public decimal? DietaryExpense { get; set; }
        public decimal? HousekeepingAndLaundryExpense { get; set; }
        public int? NursingCareExpense { get; set; }
        public int OtherPatientCareExpense { get; set; }
        public decimal? PropertyExpense { get; set; }
        public int RealEstateTax { get; set; }
        public decimal? MedicareRevenue { get; set; }
        public decimal? ComprehensivePayor1Revenue { get; set; }
        public decimal? ComprehensivePayor2Revenue { get; set; }
        public decimal? ComprehensivePayor3Revenue { get; set; }
        public decimal? OtherComprehensiveRevenue { get; set; }
        public decimal? PrivateDaysPercent { get; set; }
        public decimal? MedicareDaysPercent { get; set; }
        public decimal? MedicaidDaysPercent { get; set; }
        public decimal? OtherComprehensiveDaysPercent { get; set; }
        public decimal? PrivateDailyCensus { get; set; }
        public decimal? MedicareDailyCensus { get; set; }
        public decimal? MedicaidDailyCensus { get; set; }
        public decimal? ComprehensivePayor1DailyCensus { get; set; }
        public decimal? ComprehensivePayor2DailyCensus { get; set; }
        public decimal? ComprehensivePayor3DailyCensus { get; set; }
        public decimal ComprehensivePayor1DailyCensusPercent { get; set; }
        public decimal ComprehensivePayor2DailyCensusPercent { get; set; }
        public decimal ComprehensivePayor3DailyCensusPercent { get; set; }
        public decimal? OtherComprehensiveDailyCensus { get; set; }
        public decimal? ComprehensiveDailyCensus { get; set; }
        public int? AvailableDays { get; set; }
        public decimal PrivateRevenuePerDay { get; set; }
        public decimal MedicareRevenuePerDay { get; set; }
        public decimal MedicaidRevenuePerDay { get; set; }
        public decimal ComprehensivePayor1RevenuePerDay { get; set; }
        public decimal ComprehensivePayor2RevenuePerDay { get; set; }
        public decimal ComprehensivePayor3RevenuePerDay { get; set; }
        public decimal OtherComprehensiveRevenuePerDay { get; set; }
        public decimal ComprehensiveRevenuePerDay { get; set; }
        public decimal OtherRevenuePerDay { get; set; }
        public int? TotalRevenue { get; set; }
        public decimal GovernmentAndAdministrativeExpensePerDay { get; set; }
        public decimal DietaryExpensePerDay { get; set; }
        public decimal HousekeepingAndLaundryExpensePerDay { get; set; }
        public decimal NursingCareExpensePerDay { get; set; }
        public decimal OtherPatientCareExpensePerDay { get; set; }
        public decimal PropertyExpensePerDay { get; set; }
        public decimal RealEstateTaxPerDay { get; set; }
        public decimal? TotalExpense { get; set; }
        public decimal TotalRevenuePerDay { get; set; }
        public decimal? ComprehensiveRevenuePercent { get; set; }
        public decimal? OtherRevenuePercent { get; set; }
        public decimal TotalExpensePerDay { get; set; }
        public decimal? TotalExpensePerRevenuePercent { get; set; }
        public decimal? GovernmentAndAdministrativeExpensePerRevenuePercent { get; set; }
        public decimal? DietaryExpensePerRevenuePercent { get; set; }
        public decimal? HousekeepingAndLaundryExpensePerRevenuePercent { get; set; }
        public decimal? NursingCareExpensePerRevenuePercent { get; set; }
        public decimal? OtherPatientCareExpensePerRevenuePercent { get; set; }
        public decimal? PropertyExpensePerRevenuePercent { get; set; }
        public decimal? RealEstateTaxPerRevenuePercent { get; set; }
        public decimal? NetIncome { get; set; }
        public decimal NetIncomePerDay { get; set; }
        public decimal? NetIncomePerRevenuePercent { get; set; }
        public decimal? NetIncomePerBed { get; set; }
        public decimal? ImpliedMinValue { get; set; }
        public decimal? ImpliedMinValuePerBed { get; set; }
        public decimal? ImpliedMaxValue { get; set; }
        public decimal? ImpliedMaxValuePerBed { get; set; }
        public decimal? NursingOccupancyPercent { get; set; }
    }
}
