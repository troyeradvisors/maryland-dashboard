using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class AdministrativeService
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int Accounting { get; set; }
        public int Adjustment { get; set; }
        public int AdministratorsPayroll { get; set; }
        public int AmortizationOrganizationCost { get; set; }
        public int AmortizationStartupCost { get; set; }
        public int AutoExpense { get; set; }
        public int CentralOfficeOverhead { get; set; }
        public int Communications { get; set; }
        public int DataProcessing { get; set; }
        public int DuesAndSubscriptions { get; set; }
        public int EmployeeBenefit { get; set; }
        public int Entertaining { get; set; }
        public int GrandTotal { get; set; }
        public int InventoryLicenseTax { get; set; }
        public int Legal { get; set; }
        public int ManagementService { get; set; }
        public int NonPropertyInsurance { get; set; }
        public int OfficeStaffPayroll { get; set; }
        public int Other { get; set; }
        public int Supply { get; set; }
        public int Total { get; set; }
        public int Travel { get; set; }
    }
}
