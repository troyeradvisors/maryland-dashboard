using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Models
{
    public class CountyAverage
    {
        public int CountyCode { get; set; }
        public int FiscalYear { get; set; }

        public int? PrivateDays { get; set; }
        public decimal? PrivateDaysPercent { get; set; }
        public int? MedicareDays { get; set; }
        public decimal? MedicareDaysPercent { get; set; }
        public int? MedicaidDays { get; set; }
        public decimal? MedicaidDaysPercent { get; set; }
        public int? OtherComprehensiveDays { get; set; }
        public decimal? OtherComprehensiveDaysPercent { get; set; }
        public int? ComprehensiveDays { get; set; }
        public decimal? NursingOccupancyPercent { get; set; }
        public decimal? PrivateRevenuePerDay { get; set; }
        public decimal? MedicareRevenuePerDay { get; set; }
        public decimal? MedicaidRevenuePerDay { get; set; }
        public decimal? OtherComprehensiveRevenuePerDay { get; set; }
        public decimal? ComprehensiveRevenuePerDay { get; set; }
        public decimal? TotalRevenuePerDay { get; set; }
        public decimal? OtherRevenuePerDay { get; set; }
        public decimal? GovernmentAndAdministrativeExpensePerDay { get; set; }
        public decimal? DietaryExpensePerDay { get; set; }
        public decimal? HousekeepingAndLaundryExpensePerDay { get; set; }
        public decimal? NursingCareExpensePerDay { get; set; }
        public decimal? OtherPatientCareExpensePerDay { get; set; }
        public decimal? PropertyExpensePerDay { get; set; }
        public decimal? RealEstateTaxPerDay { get; set; }
        public decimal? TotalExpensePerDay { get; set; }
        public decimal? NetIncomePerDay { get; set; }
        public decimal? NetIncomePerRevenuePercent { get; set; }
    }
}