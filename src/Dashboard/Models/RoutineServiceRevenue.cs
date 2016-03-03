using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class RoutineServiceRevenue
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        [MaxLength(70)]
        public string ComprehensiveCareCustom1Name { get; set; }
        public int ComprehensiveCareCustom1PatientDays { get; set; }
        public int ComprehensiveCareCustom1Revenue { get; set; }
        [MaxLength(70)]
        public string ComprehensiveCareCustom2Name { get; set; }
        public int ComprehensiveCareCustom2PatientDays { get; set; }
        public int ComprehensiveCareCustom2Revenue { get; set; }
        [MaxLength(70)]
        public string ComprehensiveCareCustom3Name { get; set; }
        public int ComprehensiveCareCustom3PatientDays { get; set; }
        public int ComprehensiveCareCustom3Revenue { get; set; }
        public int ComprehensiveCareMedicaidPatientDays { get; set; }
        public int ComprehensiveCareMedicaidRevenue { get; set; }
        public int ComprehensiveCareMedicarePatientDays { get; set; }
        public int ComprehensiveCareMedicareRevenue { get; set; }
        public int? ComprehensiveCareOtherPatientDaysTotal { get; set; }
        public int? ComprehensiveCareOtherRevenueTotal { get; set; }
        public int? ComprehensiveCarePatientDaysTotal { get; set; }
        public int ComprehensiveCarePrivatePatientDays { get; set; }
        public int ComprehensiveCarePrivateRevenue { get; set; }
        public int? ComprehensiveCareRevenueTotal { get; set; }
        [MaxLength(70)]
        public string OtherCareCustom1Name { get; set; }
        public int OtherCareCustom1PatientDays { get; set; }
        public int OtherCareCustom1Revenue { get; set; }
        [MaxLength(70)]
        public string OtherCareCustom2Name { get; set; }
        public int OtherCareCustom2PatientDays { get; set; }
        public int OtherCareCustom2Revenue { get; set; }
        [MaxLength(70)]
        public string OtherCareCustom3Name { get; set; }
        public int OtherCareCustom3PatientDays { get; set; }
        public int OtherCareCustom3Revenue { get; set; }
        [MaxLength(70)]
        public string OtherCareCustom4Name { get; set; }
        public int OtherCareCustom4PatientDays { get; set; }
        public int OtherCareCustom4Revenue { get; set; }
        [MaxLength(70)]
        public string OtherCareCustom5Name { get; set; }
        public int OtherCareCustom5PatientDays { get; set; }
        public int OtherCareCustom5Revenue { get; set; }
        [MaxLength(70)]
        public string OtherCareCustom6Name { get; set; }
        public int OtherCareCustom6PatientDays { get; set; }
        public int OtherCareCustom6Revenue { get; set; }
        [MaxLength(70)]
        public string OtherCareCustom7Name { get; set; }
        public int OtherCareCustom7PatientDays { get; set; }
        public int OtherCareCustom7Revenue { get; set; }
        public int? OtherCarePatientDaysTotal { get; set; }
        public int? OtherCareRevenueTotal { get; set; }
        public int? RevenueTotal { get; set; }
    }
}
