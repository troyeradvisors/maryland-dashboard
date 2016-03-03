using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class Statistics
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int AvailableComprehensiveDays { get; set; }
        public double? ComprehensiveMedicaidPercent { get; set; }
        public double ComprehensiveOccupancyPercent { get; set; }
        public int MedicaidComprehensiveDays { get; set; }
        public int MedicareComprehensiveDays { get; set; }
        public int PrivatePayComprehensiveDays { get; set; }
        public int TotalComprehensiveDays { get; set; }
    }
}
