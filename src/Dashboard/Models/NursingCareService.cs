using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class NursingCareService
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int ContractedService { get; set; }
        public int EmployeeBenefits { get; set; }
        public int OtherAdjustments { get; set; }
        public int OtherCosts { get; set; }
        public int Payroll { get; set; }
        public int Supply { get; set; }
        public int Total { get; set; }
    }
}
