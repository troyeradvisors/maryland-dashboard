using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class RoutineService
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int DietaryAdjustment { get; set; }
        public decimal? DietaryBenefit { get; set; }
        public int DietaryContractedService { get; set; }
        public int DietaryOther { get; set; }
        public int DietaryPayroll { get; set; }
        public int DietarySupply { get; set; }
        public int DietaryTotal { get; set; }
        public int EmployeeBenefit { get; set; }
        public int HousekeepingAdjustment { get; set; }
        public decimal? HousekeepingAndLaundryBenefit { get; set; }
        public int HousekeepingContractService { get; set; }
        public int HousekeepingOther { get; set; }
        public int HousekeepingPayroll { get; set; }
        public int HousekeepingSupply { get; set; }
        public int HousekeepingTotal { get; set; }
        public int LaundryAdjustment { get; set; }
        public int LaundryContractedService { get; set; }
        public int LaundryLinenReplacement { get; set; }
        public int LaundryOther { get; set; }
        public int LaundryPayroll { get; set; }
        public int LaundrySupply { get; set; }
        public int LaundryTotal { get; set; }
        public int MainenanceMinorEquipment { get; set; }
        public int MaintenanceAdjustment { get; set; }
        public int MaintenanceContractedService { get; set; }
        public int MaintenanceOther { get; set; }
        public int MaintenancePayroll { get; set; }
        public int MaintenanceRepair { get; set; }
        public int MaintenanceSupply { get; set; }
        public int MaintenanceTotal { get; set; }
        public int MaintenanceUtility { get; set; }
        public decimal? PropertyBenefit { get; set; }
        public int Total { get; set; }
    }
}
