using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class AllowanceAndAdjustmentsToRevenue
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int AdministrativeAdjustment { get; set; }
        public int CharityServiceComprehensiveCare { get; set; }
        public int CharityServiceOther { get; set; }
        public int ConctractualAllowanceComprehensiveCareMedicare { get; set; }
        public int ContractualAllowanceComprehensiveCareMedicalAssitance { get; set; }
        public int ContractualAllowanceOtherMedicalAssistance { get; set; }
        public int ContractualAllowanceOtherMedicare { get; set; }
        [MaxLength(70)]
        public string Custom1Name { get; set; }
        public int Custom1Revenue { get; set; }
        public int DubiousAccountsProvision { get; set; }
        public int PriorYearSettlementMedicalAssistance { get; set; }
        public int PriorYearSettlementMedicare { get; set; }
    }
}
