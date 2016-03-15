using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Dashboard.Resources;
using Dashboard.Models;

namespace Dashboard.Controllers
{
    [Route("api")]
    public class DashboardController : Controller
    {
        DashboardContext Context;
        public DashboardController(DashboardContext context)
        {
            Context = context;
        }
        [HttpGet("FiscalYears")]
        public IQueryable<int> FiscalYears() { return Descriptions().Select(e => e.FiscalYear).Distinct().OrderByDescending(e => e); }

        [HttpGet("HomeViews")]
        public IQueryable<HomeView> HomeViews(int? year = null)
        {
            var query = from home in Homes()
                        join description in Descriptions() on home.PIN equals description.PIN
                        orderby home.Name
                        select new HomeView() { Name = home.Name, PIN = home.PIN, FiscalYear = description.FiscalYear, CountyCode = home.CountyCode };
            if (year.HasValue)
                query = query.Where(e => e.FiscalYear == year);
            return query;
        }

        [HttpGet("FinanceViews")]
        public IQueryable<FinanceView> FinanceViews()
        {
            return
                from finance in Finances()
                join home in Homes() on finance.PIN equals home.PIN
                orderby home.Name
                select new FinanceView()
                {
                    PIN = home.PIN,
                    FiscalYear = finance.FiscalYear,
                    Name = home.Name,
                    Street = home.Street,
                    State = home.State,
                    City = home.City,
                    Beds = finance.CertifiedBedCount,
                    Occupancy = (double)finance.NursingOccupancyPercent,
                    Expense = (double)finance.TotalExpense,
                    Revenue = (double)finance.TotalRevenue,
                    Income = (double)finance.NetIncome,
                    ProfitMargin = (double)finance.NetIncomePerRevenuePercent,
                    MedicareRevenuePerDay = (double)finance.MedicareRevenuePerDay
                };
        }

        [HttpGet("Homes")]
        public IQueryable<Home> Homes(int? pin = null, string pins = null)
        {
            var query = Context.Homes.Where(e => Context.Descriptions.Any(f => e.PIN == f.PIN));
            if (pin != null)
                query = query.Where(e => e.PIN == pin);
            else if (!string.IsNullOrWhiteSpace(pins))
            {
                var p = pins.Split(' ').Select(e => int.Parse(e)).ToList();
                query = query.Where(x => p.Contains(x.PIN));
            }
            return query;
        }

        [HttpGet("Finances")]
        public IQueryable<Summary> Finances(string pins = null, int? fiscalYear = null)
        {
            var query = Context.Summaries.AsQueryable();
            if (!string.IsNullOrWhiteSpace(pins))
                query = query.Where(e => pins.Contains(e.PIN.ToString()));
            if (fiscalYear != null)
                query = query.Where(e => e.FiscalYear == fiscalYear);
            return query;
        }

        [HttpGet("CountyAverages")]
        public IQueryable<CountyAverage> CountyAverages() { return Context.CountyAverages; }
        [HttpGet("Descriptions")]
        public IQueryable<Description> Descriptions() { return Context.Descriptions; }
        [HttpGet("StateAverages")]
        public IQueryable<StateAverage> StateAverages() { return Context.StateAverages; }
    }
}
