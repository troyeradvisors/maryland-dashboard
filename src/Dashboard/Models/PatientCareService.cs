using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class PatientCareService
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int BarberAndBeautyShopPayroll { get; set; }
        public int EmployeeBenefit { get; set; }
        public int? LaboratoryContractedService { get; set; }
        public int? LaboratoryPayroll { get; set; }
        public int? LaboratorySupply { get; set; }
        public int MedicalDirectorContractedService { get; set; }
        public int MedicalDirectorPayroll { get; set; }
        public int MedicalDirectorSupply { get; set; }
        public int OccupationalTherapyContractedService { get; set; }
        public int OccupationalTherapyPayroll { get; set; }
        public int OccupationalTherapySupply { get; set; }
        public int Other { get; set; }
        public int OtherAdjustment { get; set; }
        public int OxygenContractedService { get; set; }
        public int OxygenPayroll { get; set; }
        public int OxygenSupply { get; set; }
        public int PatientCareContractedService { get; set; }
        public int PatientCarePayroll { get; set; }
        public int PatientCareSupply { get; set; }
        public int PharmacyContractedService { get; set; }
        public int PharmacyOverTheCounterDrugs { get; set; }
        public int PharmacyPayroll { get; set; }
        public int PharmacySupply { get; set; }
        public int PhysicalTherapyContractedService { get; set; }
        public int PhysicalTherapyPayroll { get; set; }
        public int PhysicalTherapySupply { get; set; }
        public int? RadiologyContractedService { get; set; }
        public int? RadiologyPayroll { get; set; }
        public int? RadiologySupply { get; set; }
        public int RawFood { get; set; }
        public int RecreationContractedService { get; set; }
        public int RecreationPayroll { get; set; }
        public int RecreationSupply { get; set; }
        public int ReligiousServiceContractedService { get; set; }
        public int ReligiousServiceOther { get; set; }
        public int ReligiousServicePayroll { get; set; }
        public int ReligiousServiceSupply { get; set; }
        public int ReligiousServiceTotal { get; set; }
        public int SocialServiceContractedService { get; set; }
        public int SocialServiceOther { get; set; }
        public int SocialServicePayroll { get; set; }
        public int SocialServiceSupply { get; set; }
        public int SocialServiceTotal { get; set; }
        public int? SpeechTherapyContractedService { get; set; }
        public int? SpeechTherapyPayroll { get; set; }
        public int? SpeechTherapySupply { get; set; }
        public int Total { get; set; }
    }
}
