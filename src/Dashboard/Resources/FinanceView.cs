using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Resources
{
    public class FinanceView
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public double Occupancy { get; set; }
        public int? Beds { get; set; }
        public double Revenue { get; set; }
        public double Expense { get; set; }
        public double Income { get; set; }
        public double ProfitMargin { get; set; }
        public double MedicareRevenuePerDay { get; set; }
    }
}
