using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class Description
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public DateTime FiscalEndDate { get; set; }
        public int OperatingDays { get; set; }
    }
}
