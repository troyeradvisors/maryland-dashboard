using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Dashboard.Models;

namespace dashboard.Migrations
{
    [DbContext(typeof(DashboardContext))]
    partial class DashboardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Dashboard.Models.CountyAverage", b =>
                {
                    b.Property<int>("CountyCode");

                    b.Property<int>("FiscalYear");

                    b.Property<int?>("ComprehensiveDays");

                    b.Property<decimal?>("ComprehensiveRevenuePerDay");

                    b.Property<decimal?>("DietaryExpensePerDay");

                    b.Property<decimal?>("GovernmentAndAdministrativeExpensePerDay");

                    b.Property<decimal?>("HousekeepingAndLaundryExpensePerDay");

                    b.Property<int?>("MedicaidDays");

                    b.Property<decimal?>("MedicaidDaysPercent");

                    b.Property<decimal?>("MedicaidRevenuePerDay");

                    b.Property<int?>("MedicareDays");

                    b.Property<decimal?>("MedicareDaysPercent");

                    b.Property<decimal?>("MedicareRevenuePerDay");

                    b.Property<decimal?>("NetIncomePerDay");

                    b.Property<decimal?>("NetIncomePerRevenuePercent");

                    b.Property<decimal?>("NursingCareExpensePerDay");

                    b.Property<decimal?>("NursingOccupancyPercent");

                    b.Property<int?>("OtherComprehensiveDays");

                    b.Property<decimal?>("OtherComprehensiveDaysPercent");

                    b.Property<decimal?>("OtherComprehensiveRevenuePerDay");

                    b.Property<decimal?>("OtherPatientCareExpensePerDay");

                    b.Property<decimal?>("OtherRevenuePerDay");

                    b.Property<int?>("PrivateDays");

                    b.Property<decimal?>("PrivateDaysPercent");

                    b.Property<decimal?>("PrivateRevenuePerDay");

                    b.Property<decimal?>("PropertyExpensePerDay");

                    b.Property<decimal?>("RealEstateTaxPerDay");

                    b.Property<decimal?>("TotalExpensePerDay");

                    b.Property<decimal?>("TotalRevenuePerDay");

                    b.HasKey("CountyCode", "FiscalYear");
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

            modelBuilder.Entity("Dashboard.Models.StateAverage", b =>
                {
                    b.Property<string>("State")
                        .HasAnnotation("MaxLength", 2);

                    b.Property<int>("FiscalYear");

                    b.Property<int?>("ComprehensiveDays");

                    b.Property<decimal?>("ComprehensiveRevenuePerDay");

                    b.Property<decimal?>("DietaryExpensePerDay");

                    b.Property<decimal?>("GovernmentAndAdministrativeExpensePerDay");

                    b.Property<decimal?>("HousekeepingAndLaundryExpensePerDay");

                    b.Property<int?>("MedicaidDays");

                    b.Property<decimal?>("MedicaidDaysPercent");

                    b.Property<decimal?>("MedicaidRevenuePerDay");

                    b.Property<int?>("MedicareDays");

                    b.Property<decimal?>("MedicareDaysPercent");

                    b.Property<decimal?>("MedicareRevenuePerDay");

                    b.Property<decimal?>("NetIncomePerDay");

                    b.Property<decimal?>("NetIncomePerRevenuePercent");

                    b.Property<decimal?>("NursingCareExpensePerDay");

                    b.Property<decimal?>("NursingOccupancyPercent");

                    b.Property<int?>("OtherComprehensiveDays");

                    b.Property<decimal?>("OtherComprehensiveDaysPercent");

                    b.Property<decimal?>("OtherComprehensiveRevenuePerDay");

                    b.Property<decimal?>("OtherPatientCareExpensePerDay");

                    b.Property<decimal?>("OtherRevenuePerDay");

                    b.Property<int?>("PrivateDays");

                    b.Property<decimal?>("PrivateDaysPercent");

                    b.Property<decimal?>("PrivateRevenuePerDay");

                    b.Property<decimal?>("PropertyExpensePerDay");

                    b.Property<decimal?>("RealEstateTaxPerDay");

                    b.Property<decimal?>("TotalExpensePerDay");

                    b.Property<decimal?>("TotalRevenuePerDay");

                    b.HasKey("State", "FiscalYear");
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

            modelBuilder.Entity("Dashboard.Models.Summary", b =>
                {
                    b.Property<int>("PIN");

                    b.Property<int>("FiscalYear");

                    b.Property<int?>("AvailableDays");

                    b.Property<int?>("CertifiedBedCount");

                    b.Property<int>("ComprehensiveCareCustom1InsuranceDays");

                    b.Property<int>("ComprehensiveCareCustom2InsuranceDays");

                    b.Property<int>("ComprehensiveCareCustom3InsuranceDays");

                    b.Property<decimal?>("ComprehensiveDailyCensus");

                    b.Property<int?>("ComprehensiveDays");

                    b.Property<decimal?>("ComprehensivePayor1DailyCensus");

                    b.Property<decimal>("ComprehensivePayor1DailyCensusPercent");

                    b.Property<int>("ComprehensivePayor1Days");

                    b.Property<string>("ComprehensivePayor1Name");

                    b.Property<decimal?>("ComprehensivePayor1Revenue");

                    b.Property<decimal>("ComprehensivePayor1RevenuePerDay");

                    b.Property<decimal?>("ComprehensivePayor2DailyCensus");

                    b.Property<decimal>("ComprehensivePayor2DailyCensusPercent");

                    b.Property<int>("ComprehensivePayor2Days");

                    b.Property<string>("ComprehensivePayor2Name");

                    b.Property<decimal?>("ComprehensivePayor2Revenue");

                    b.Property<decimal>("ComprehensivePayor2RevenuePerDay");

                    b.Property<decimal?>("ComprehensivePayor3DailyCensus");

                    b.Property<decimal>("ComprehensivePayor3DailyCensusPercent");

                    b.Property<int>("ComprehensivePayor3Days");

                    b.Property<string>("ComprehensivePayor3Name");

                    b.Property<decimal?>("ComprehensivePayor3Revenue");

                    b.Property<decimal>("ComprehensivePayor3RevenuePerDay");

                    b.Property<int?>("ComprehensiveRevenue");

                    b.Property<decimal>("ComprehensiveRevenuePerDay");

                    b.Property<decimal?>("ComprehensiveRevenuePercent");

                    b.Property<decimal?>("DietaryExpense");

                    b.Property<decimal>("DietaryExpensePerDay");

                    b.Property<decimal?>("DietaryExpensePerRevenuePercent");

                    b.Property<int?>("GovernmentAndAdministrativeExpense");

                    b.Property<decimal>("GovernmentAndAdministrativeExpensePerDay");

                    b.Property<decimal?>("GovernmentAndAdministrativeExpensePerRevenuePercent");

                    b.Property<decimal?>("HousekeepingAndLaundryExpense");

                    b.Property<decimal>("HousekeepingAndLaundryExpensePerDay");

                    b.Property<decimal?>("HousekeepingAndLaundryExpensePerRevenuePercent");

                    b.Property<decimal?>("ImpliedMaxValue");

                    b.Property<decimal?>("ImpliedMaxValuePerBed");

                    b.Property<decimal?>("ImpliedMinValue");

                    b.Property<decimal?>("ImpliedMinValuePerBed");

                    b.Property<decimal?>("MedicaidDailyCensus");

                    b.Property<int>("MedicaidDays");

                    b.Property<decimal?>("MedicaidDaysPercent");

                    b.Property<int?>("MedicaidRevenue");

                    b.Property<decimal>("MedicaidRevenuePerDay");

                    b.Property<decimal?>("MedicareDailyCensus");

                    b.Property<int>("MedicareDays");

                    b.Property<decimal?>("MedicareDaysPercent");

                    b.Property<decimal?>("MedicareRevenue");

                    b.Property<decimal>("MedicareRevenuePerDay");

                    b.Property<decimal?>("NetIncome");

                    b.Property<decimal?>("NetIncomePerBed");

                    b.Property<decimal>("NetIncomePerDay");

                    b.Property<decimal?>("NetIncomePerRevenuePercent");

                    b.Property<int?>("NursingCareExpense");

                    b.Property<decimal>("NursingCareExpensePerDay");

                    b.Property<decimal?>("NursingCareExpensePerRevenuePercent");

                    b.Property<decimal?>("NursingOccupancyPercent");

                    b.Property<int>("OperatingDays");

                    b.Property<int?>("OtherCareDays");

                    b.Property<decimal?>("OtherComprehensiveDailyCensus");

                    b.Property<int?>("OtherComprehensiveDays");

                    b.Property<decimal?>("OtherComprehensiveDaysPercent");

                    b.Property<decimal?>("OtherComprehensiveRevenue");

                    b.Property<decimal>("OtherComprehensiveRevenuePerDay");

                    b.Property<int>("OtherPatientCareExpense");

                    b.Property<decimal>("OtherPatientCareExpensePerDay");

                    b.Property<decimal?>("OtherPatientCareExpensePerRevenuePercent");

                    b.Property<int?>("OtherRevenue");

                    b.Property<decimal>("OtherRevenuePerDay");

                    b.Property<decimal?>("OtherRevenuePercent");

                    b.Property<decimal?>("PrivateDailyCensus");

                    b.Property<int>("PrivateDays");

                    b.Property<decimal?>("PrivateDaysPercent");

                    b.Property<int>("PrivateRevenue");

                    b.Property<decimal>("PrivateRevenuePerDay");

                    b.Property<decimal?>("PropertyExpense");

                    b.Property<decimal>("PropertyExpensePerDay");

                    b.Property<decimal?>("PropertyExpensePerRevenuePercent");

                    b.Property<int>("RealEstateTax");

                    b.Property<decimal>("RealEstateTaxPerDay");

                    b.Property<decimal?>("RealEstateTaxPerRevenuePercent");

                    b.Property<int>("SpecialServiceRevenue");

                    b.Property<int?>("TotalDays");

                    b.Property<decimal?>("TotalExpense");

                    b.Property<decimal>("TotalExpensePerDay");

                    b.Property<decimal?>("TotalExpensePerRevenuePercent");

                    b.Property<int?>("TotalRevenue");

                    b.Property<decimal>("TotalRevenuePerDay");

                    b.Property<int>("UnadjustedComprehensivePayor1Revenue");

                    b.Property<int>("UnadjustedComprehensivePayor2Revenue");

                    b.Property<int>("UnadjustedComprehensivePayor3Revenue");

                    b.Property<int?>("UnadjustedMedicareRevenue");

                    b.Property<int?>("UnadjustedOtherComprehensiveRevenue");

                    b.HasKey("PIN", "FiscalYear");
                });
        }
    }
}
