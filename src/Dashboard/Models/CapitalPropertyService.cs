using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class CapitalPropertyService
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int HomeOfficeEquipmentDepreciation { get; set; }
        public int HomeOfficeEquipmentInterest { get; set; }
        public int HomeOfficeRealEstateDepreciation { get; set; }
        public int HomeOfficeRealEstateInterest { get; set; }
        public int RecurringAdjustment { get; set; }
        public int RecurringMajorEquipmentInsurance { get; set; }
        public int RecurringMajorEquipmentInterest { get; set; }
        public int RecurringMajorEquipmentTax { get; set; }
        public int RecurringMortgageAcquisitionCostAmortization { get; set; }
        public int RecurringRealEstateInsurance { get; set; }
        public int RecurringRealEstateInterest { get; set; }
        public int RecurringRealEstateTax { get; set; }
        public int RecurringTotal { get; set; }
        public int ReplacedAdjustment { get; set; }
        public int ReplacedLeaseholdImprovementAmortization { get; set; }
        public int ReplacedMajorEquipmentDepreciation { get; set; }
        public int ReplacedMajorEquipmentRental { get; set; }
        public int ReplacedRealEstateDepreciation { get; set; }
        public int ReplacedRealEstateRental { get; set; }
        public int ReplacedTotal { get; set; }
    }
}
