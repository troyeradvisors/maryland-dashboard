using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Dashboard.Models;

namespace dashboard.Migrations
{
    [DbContext(typeof(DashboardContext))]
    [Migration("20160303212955_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dashboard.Models.AdministrativeService", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("Accounting");

                    b.Property<int>("Adjustment");

                    b.Property<int>("AdministratorsPayroll");

                    b.Property<int>("AmortizationOrganizationCost");

                    b.Property<int>("AmortizationStartupCost");

                    b.Property<int>("AutoExpense");

                    b.Property<int>("CentralOfficeOverhead");

                    b.Property<int>("Communications");

                    b.Property<int>("DataProcessing");

                    b.Property<int>("DuesAndSubscriptions");

                    b.Property<int>("EmployeeBenefit");

                    b.Property<int>("Entertaining");

                    b.Property<int>("GrandTotal");

                    b.Property<int>("InventoryLicenseTax");

                    b.Property<int>("Legal");

                    b.Property<int>("ManagementService");

                    b.Property<int>("NonPropertyInsurance");

                    b.Property<int>("OfficeStaffPayroll");

                    b.Property<int>("Other");

                    b.Property<int>("Supply");

                    b.Property<int>("Total");

                    b.Property<int>("Travel");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.AdministrativeServiceOther", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("DepreciationTransportationEquipment");

                    b.Property<int>("EmployeeBenefit");

                    b.Property<int>("InterestWorkingCapitalAndAutoLoan");

                    b.Property<int>("MedicalContractedService");

                    b.Property<int>("MedicalPayroll");

                    b.Property<int>("MedicalSupply");

                    b.Property<int>("MedicalTotal");

                    b.Property<int>("QualityAssurance");

                    b.Property<int>("TrainingContractedService");

                    b.Property<int>("TrainingPayroll");

                    b.Property<int>("TrainingSupply");

                    b.Property<int>("TrainingTotal");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.AllowanceAndAdjustmentsToRevenue", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("AdministrativeAdjustment");

                    b.Property<int>("CharityServiceComprehensiveCare");

                    b.Property<int>("CharityServiceOther");

                    b.Property<int>("ConctractualAllowanceComprehensiveCareMedicare");

                    b.Property<int>("ContractualAllowanceComprehensiveCareMedicalAssitance");

                    b.Property<int>("ContractualAllowanceOtherMedicalAssistance");

                    b.Property<int>("ContractualAllowanceOtherMedicare");

                    b.Property<string>("Custom1Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("Custom1Revenue");

                    b.Property<int>("DubiousAccountsProvision");

                    b.Property<int>("PriorYearSettlementMedicalAssistance");

                    b.Property<int>("PriorYearSettlementMedicare");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.AncillaryRevenue", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("AttachmentsRevenue");

                    b.Property<string>("Custom1Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("Custom1Revenue");

                    b.Property<string>("Custom2Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("Custom2Revenue");

                    b.Property<int>("EquipmentRental");

                    b.Property<int>("Laboratory");

                    b.Property<int>("MedicalSupplies");

                    b.Property<int>("OccupationalTherapy");

                    b.Property<int>("Oxygen");

                    b.Property<int>("Pharmacy");

                    b.Property<int>("PhysicalTherapy");

                    b.Property<int>("PhysicianCare");

                    b.Property<int>("Radiology");

                    b.Property<int>("RecreationalActivities");

                    b.Property<int>("SpeechTherapy");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.CapitalPropertyService", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("HomeOfficeEquipmentDepreciation");

                    b.Property<int>("HomeOfficeEquipmentInterest");

                    b.Property<int>("HomeOfficeRealEstateDepreciation");

                    b.Property<int>("HomeOfficeRealEstateInterest");

                    b.Property<int>("RecurringAdjustment");

                    b.Property<int>("RecurringMajorEquipmentInsurance");

                    b.Property<int>("RecurringMajorEquipmentInterest");

                    b.Property<int>("RecurringMajorEquipmentTax");

                    b.Property<int>("RecurringMortgageAcquisitionCostAmortization");

                    b.Property<int>("RecurringRealEstateInsurance");

                    b.Property<int>("RecurringRealEstateInterest");

                    b.Property<int>("RecurringRealEstateTax");

                    b.Property<int>("RecurringTotal");

                    b.Property<int>("ReplacedAdjustment");

                    b.Property<int>("ReplacedLeaseholdImprovementAmortization");

                    b.Property<int>("ReplacedMajorEquipmentDepreciation");

                    b.Property<int>("ReplacedMajorEquipmentRental");

                    b.Property<int>("ReplacedRealEstateDepreciation");

                    b.Property<int>("ReplacedRealEstateRental");

                    b.Property<int>("ReplacedTotal");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.Description", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<DateTime>("FiscalEndDate")
                        .HasAnnotation("Relational:ColumnType", "date");

                    b.Property<int>("OperatingDays");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.Home", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<int>("CountyCode");

                    b.Property<string>("CountyName")
                        .IsRequired();

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("Phone");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 2)
                        .HasAnnotation("Relational:ColumnType", "nchar");

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<int>("ZipCode");

                    b.HasKey("PIN");
                });

            modelBuilder.Entity("Dashboard.Models.NursingCareService", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("ContractedService");

                    b.Property<int>("EmployeeBenefits");

                    b.Property<int>("OtherAdjustments");

                    b.Property<int>("OtherCosts");

                    b.Property<int>("Payroll");

                    b.Property<int>("Supply");

                    b.Property<int>("Total");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.OperationsSummary", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("AdministrativeServiceAdjustedExpense");

                    b.Property<int>("AdministrativeServiceBookExpense");

                    b.Property<int>("BeforeIncomeTaxNetIncome");

                    b.Property<int>("CapitalOrPropertyServiceAdjusedExpense");

                    b.Property<int>("CapitalOrPropertyServiceBookExpense");

                    b.Property<int>("CapitalValueRentalAdjustedExpense");

                    b.Property<int>("CapitalValueRentalBookExpense");

                    b.Property<int>("GrossOperatingProfit");

                    b.Property<int>("IncomeTaxProvision");

                    b.Property<int>("LessAllowancesAndAdjustmentsRevenue");

                    b.Property<int>("NetRevenue");

                    b.Property<int>("NonOperatingRevenue");

                    b.Property<int>("NonReimbursableExpense");

                    b.Property<int>("NursingCareServiceAdjustedExpense");

                    b.Property<int>("NursingCareServiceBookExpense");

                    b.Property<int>("OtherPatientCareServiceAdjustedExpense");

                    b.Property<int>("OtherPatientCareServiceBookExpense");

                    b.Property<int>("PerFinancialStatementsNetIncome");

                    b.Property<int>("RoutineServiceBookExpense");

                    b.Property<int>("RoutineServiceRevenue");

                    b.Property<int>("RoutingServiceAdjustedExpense");

                    b.Property<int>("SpecialServiceRevenue");

                    b.Property<int>("TotalAdjustedOperatingExpense");

                    b.Property<int>("TotalBookOperatingExpense");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.PatientCareService", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("BarberAndBeautyShopPayroll");

                    b.Property<int>("EmployeeBenefit");

                    b.Property<int?>("LaboratoryContractedService");

                    b.Property<int?>("LaboratoryPayroll");

                    b.Property<int?>("LaboratorySupply");

                    b.Property<int>("MedicalDirectorContractedService");

                    b.Property<int>("MedicalDirectorPayroll");

                    b.Property<int>("MedicalDirectorSupply");

                    b.Property<int>("OccupationalTherapyContractedService");

                    b.Property<int>("OccupationalTherapyPayroll");

                    b.Property<int>("OccupationalTherapySupply");

                    b.Property<int>("Other");

                    b.Property<int>("OtherAdjustment");

                    b.Property<int>("OxygenContractedService");

                    b.Property<int>("OxygenPayroll");

                    b.Property<int>("OxygenSupply");

                    b.Property<int>("PatientCareContractedService");

                    b.Property<int>("PatientCarePayroll");

                    b.Property<int>("PatientCareSupply");

                    b.Property<int>("PharmacyContractedService");

                    b.Property<int>("PharmacyOverTheCounterDrugs");

                    b.Property<int>("PharmacyPayroll");

                    b.Property<int>("PharmacySupply");

                    b.Property<int>("PhysicalTherapyContractedService");

                    b.Property<int>("PhysicalTherapyPayroll");

                    b.Property<int>("PhysicalTherapySupply");

                    b.Property<int?>("RadiologyContractedService");

                    b.Property<int?>("RadiologyPayroll");

                    b.Property<int?>("RadiologySupply");

                    b.Property<int>("RawFood");

                    b.Property<int>("RecreationContractedService");

                    b.Property<int>("RecreationPayroll");

                    b.Property<int>("RecreationSupply");

                    b.Property<int>("ReligiousServiceContractedService");

                    b.Property<int>("ReligiousServiceOther");

                    b.Property<int>("ReligiousServicePayroll");

                    b.Property<int>("ReligiousServiceSupply");

                    b.Property<int>("ReligiousServiceTotal");

                    b.Property<int>("SocialServiceContractedService");

                    b.Property<int>("SocialServiceOther");

                    b.Property<int>("SocialServicePayroll");

                    b.Property<int>("SocialServiceSupply");

                    b.Property<int>("SocialServiceTotal");

                    b.Property<int?>("SpeechTherapyContractedService");

                    b.Property<int?>("SpeechTherapyPayroll");

                    b.Property<int?>("SpeechTherapySupply");

                    b.Property<int>("Total");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.RoutineService", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("DietaryAdjustment");

                    b.Property<decimal?>("DietaryBenefit")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<int>("DietaryContractedService");

                    b.Property<int>("DietaryOther");

                    b.Property<int>("DietaryPayroll");

                    b.Property<int>("DietarySupply");

                    b.Property<int>("DietaryTotal");

                    b.Property<int>("EmployeeBenefit");

                    b.Property<int>("HousekeepingAdjustment");

                    b.Property<decimal?>("HousekeepingAndLaundryBenefit")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<int>("HousekeepingContractService");

                    b.Property<int>("HousekeepingOther");

                    b.Property<int>("HousekeepingPayroll");

                    b.Property<int>("HousekeepingSupply");

                    b.Property<int>("HousekeepingTotal");

                    b.Property<int>("LaundryAdjustment");

                    b.Property<int>("LaundryContractedService");

                    b.Property<int>("LaundryLinenReplacement");

                    b.Property<int>("LaundryOther");

                    b.Property<int>("LaundryPayroll");

                    b.Property<int>("LaundrySupply");

                    b.Property<int>("LaundryTotal");

                    b.Property<int>("MainenanceMinorEquipment");

                    b.Property<int>("MaintenanceAdjustment");

                    b.Property<int>("MaintenanceContractedService");

                    b.Property<int>("MaintenanceOther");

                    b.Property<int>("MaintenancePayroll");

                    b.Property<int>("MaintenanceRepair");

                    b.Property<int>("MaintenanceSupply");

                    b.Property<int>("MaintenanceTotal");

                    b.Property<int>("MaintenanceUtility");

                    b.Property<decimal?>("PropertyBenefit")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<int>("Total");

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.RoutineServiceRevenue", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<string>("ComprehensiveCareCustom1Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("ComprehensiveCareCustom1PatientDays");

                    b.Property<int>("ComprehensiveCareCustom1Revenue");

                    b.Property<string>("ComprehensiveCareCustom2Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("ComprehensiveCareCustom2PatientDays");

                    b.Property<int>("ComprehensiveCareCustom2Revenue");

                    b.Property<string>("ComprehensiveCareCustom3Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("ComprehensiveCareCustom3PatientDays");

                    b.Property<int>("ComprehensiveCareCustom3Revenue");

                    b.Property<int>("ComprehensiveCareMedicaidPatientDays");

                    b.Property<int>("ComprehensiveCareMedicaidRevenue");

                    b.Property<int>("ComprehensiveCareMedicarePatientDays");

                    b.Property<int>("ComprehensiveCareMedicareRevenue");

                    b.Property<int?>("ComprehensiveCareOtherPatientDaysTotal")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("ComprehensiveCareOtherRevenueTotal")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("ComprehensiveCarePatientDaysTotal")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("ComprehensiveCarePrivatePatientDays");

                    b.Property<int>("ComprehensiveCarePrivateRevenue");

                    b.Property<int?>("ComprehensiveCareRevenueTotal")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("OtherCareCustom1Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("OtherCareCustom1PatientDays");

                    b.Property<int>("OtherCareCustom1Revenue");

                    b.Property<string>("OtherCareCustom2Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("OtherCareCustom2PatientDays");

                    b.Property<int>("OtherCareCustom2Revenue");

                    b.Property<string>("OtherCareCustom3Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("OtherCareCustom3PatientDays");

                    b.Property<int>("OtherCareCustom3Revenue");

                    b.Property<string>("OtherCareCustom4Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("OtherCareCustom4PatientDays");

                    b.Property<int>("OtherCareCustom4Revenue");

                    b.Property<string>("OtherCareCustom5Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("OtherCareCustom5PatientDays");

                    b.Property<int>("OtherCareCustom5Revenue");

                    b.Property<string>("OtherCareCustom6Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("OtherCareCustom6PatientDays");

                    b.Property<int>("OtherCareCustom6Revenue");

                    b.Property<string>("OtherCareCustom7Name")
                        .HasAnnotation("MaxLength", 70);

                    b.Property<int>("OtherCareCustom7PatientDays");

                    b.Property<int>("OtherCareCustom7Revenue");

                    b.Property<int?>("OtherCarePatientDaysTotal")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("OtherCareRevenueTotal")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("RevenueTotal")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("PIN", "FiscalYear");
                });

            modelBuilder.Entity("Dashboard.Models.Statistics", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int>("AvailableComprehensiveDays");

                    b.Property<double?>("ComprehensiveMedicaidPercent");

                    b.Property<double>("ComprehensiveOccupancyPercent");

                    b.Property<int>("MedicaidComprehensiveDays");

                    b.Property<int>("MedicareComprehensiveDays");

                    b.Property<int>("PrivatePayComprehensiveDays");

                    b.Property<int>("TotalComprehensiveDays");

                    b.HasKey("PIN", "FiscalYear");
                });
        }
    }
}
