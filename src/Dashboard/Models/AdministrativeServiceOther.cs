using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class AdministrativeServiceOther
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int DepreciationTransportationEquipment { get; set; }
        public int EmployeeBenefit { get; set; }
        public int InterestWorkingCapitalAndAutoLoan { get; set; }
        public int MedicalContractedService { get; set; }
        public int MedicalPayroll { get; set; }
        public int MedicalSupply { get; set; }
        public int MedicalTotal { get; set; }
        public int QualityAssurance { get; set; }
        public int TrainingContractedService { get; set; }
        public int TrainingPayroll { get; set; }
        public int TrainingSupply { get; set; }
        public int TrainingTotal { get; set; }
    }
}
