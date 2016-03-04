using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace dashboard.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdministrativeService",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    Accounting = table.Column<int>(nullable: false),
                    Adjustment = table.Column<int>(nullable: false),
                    AdministratorsPayroll = table.Column<int>(nullable: false),
                    AmortizationOrganizationCost = table.Column<int>(nullable: false),
                    AmortizationStartupCost = table.Column<int>(nullable: false),
                    AutoExpense = table.Column<int>(nullable: false),
                    CentralOfficeOverhead = table.Column<int>(nullable: false),
                    Communications = table.Column<int>(nullable: false),
                    DataProcessing = table.Column<int>(nullable: false),
                    DuesAndSubscriptions = table.Column<int>(nullable: false),
                    EmployeeBenefit = table.Column<int>(nullable: false),
                    Entertaining = table.Column<int>(nullable: false),
                    GrandTotal = table.Column<int>(nullable: false),
                    InventoryLicenseTax = table.Column<int>(nullable: false),
                    Legal = table.Column<int>(nullable: false),
                    ManagementService = table.Column<int>(nullable: false),
                    NonPropertyInsurance = table.Column<int>(nullable: false),
                    OfficeStaffPayroll = table.Column<int>(nullable: false),
                    Other = table.Column<int>(nullable: false),
                    Supply = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    Travel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministrativeService", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "AdministrativeServiceOther",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    DepreciationTransportationEquipment = table.Column<int>(nullable: false),
                    EmployeeBenefit = table.Column<int>(nullable: false),
                    InterestWorkingCapitalAndAutoLoan = table.Column<int>(nullable: false),
                    MedicalContractedService = table.Column<int>(nullable: false),
                    MedicalPayroll = table.Column<int>(nullable: false),
                    MedicalSupply = table.Column<int>(nullable: false),
                    MedicalTotal = table.Column<int>(nullable: false),
                    QualityAssurance = table.Column<int>(nullable: false),
                    TrainingContractedService = table.Column<int>(nullable: false),
                    TrainingPayroll = table.Column<int>(nullable: false),
                    TrainingSupply = table.Column<int>(nullable: false),
                    TrainingTotal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministrativeServiceOther", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "AllowanceAndAdjustmentsToRevenue",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    AdministrativeAdjustment = table.Column<int>(nullable: false),
                    CharityServiceComprehensiveCare = table.Column<int>(nullable: false),
                    CharityServiceOther = table.Column<int>(nullable: false),
                    ConctractualAllowanceComprehensiveCareMedicare = table.Column<int>(nullable: false),
                    ContractualAllowanceComprehensiveCareMedicalAssitance = table.Column<int>(nullable: false),
                    ContractualAllowanceOtherMedicalAssistance = table.Column<int>(nullable: false),
                    ContractualAllowanceOtherMedicare = table.Column<int>(nullable: false),
                    Custom1Name = table.Column<string>(nullable: true),
                    Custom1Revenue = table.Column<int>(nullable: false),
                    DubiousAccountsProvision = table.Column<int>(nullable: false),
                    PriorYearSettlementMedicalAssistance = table.Column<int>(nullable: false),
                    PriorYearSettlementMedicare = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowanceAndAdjustmentsToRevenue", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "AncillaryRevenue",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    AttachmentsRevenue = table.Column<int>(nullable: false),
                    Custom1Name = table.Column<string>(nullable: true),
                    Custom1Revenue = table.Column<int>(nullable: false),
                    Custom2Name = table.Column<string>(nullable: true),
                    Custom2Revenue = table.Column<int>(nullable: false),
                    EquipmentRental = table.Column<int>(nullable: false),
                    Laboratory = table.Column<int>(nullable: false),
                    MedicalSupplies = table.Column<int>(nullable: false),
                    OccupationalTherapy = table.Column<int>(nullable: false),
                    Oxygen = table.Column<int>(nullable: false),
                    Pharmacy = table.Column<int>(nullable: false),
                    PhysicalTherapy = table.Column<int>(nullable: false),
                    PhysicianCare = table.Column<int>(nullable: false),
                    Radiology = table.Column<int>(nullable: false),
                    RecreationalActivities = table.Column<int>(nullable: false),
                    SpeechTherapy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AncillaryRevenue", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "CapitalPropertyService",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    HomeOfficeEquipmentDepreciation = table.Column<int>(nullable: false),
                    HomeOfficeEquipmentInterest = table.Column<int>(nullable: false),
                    HomeOfficeRealEstateDepreciation = table.Column<int>(nullable: false),
                    HomeOfficeRealEstateInterest = table.Column<int>(nullable: false),
                    RecurringAdjustment = table.Column<int>(nullable: false),
                    RecurringMajorEquipmentInsurance = table.Column<int>(nullable: false),
                    RecurringMajorEquipmentInterest = table.Column<int>(nullable: false),
                    RecurringMajorEquipmentTax = table.Column<int>(nullable: false),
                    RecurringMortgageAcquisitionCostAmortization = table.Column<int>(nullable: false),
                    RecurringRealEstateInsurance = table.Column<int>(nullable: false),
                    RecurringRealEstateInterest = table.Column<int>(nullable: false),
                    RecurringRealEstateTax = table.Column<int>(nullable: false),
                    RecurringTotal = table.Column<int>(nullable: false),
                    ReplacedAdjustment = table.Column<int>(nullable: false),
                    ReplacedLeaseholdImprovementAmortization = table.Column<int>(nullable: false),
                    ReplacedMajorEquipmentDepreciation = table.Column<int>(nullable: false),
                    ReplacedMajorEquipmentRental = table.Column<int>(nullable: false),
                    ReplacedRealEstateDepreciation = table.Column<int>(nullable: false),
                    ReplacedRealEstateRental = table.Column<int>(nullable: false),
                    ReplacedTotal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapitalPropertyService", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "CountyAverage",
                columns: table => new
                {
                    CountyCode = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    ComprehensiveDays = table.Column<int>(nullable: true),
                    ComprehensiveRevenuePerDay = table.Column<decimal>(nullable: true),
                    DietaryExpensePerDay = table.Column<decimal>(nullable: true),
                    GovernmentAndAdministrativeExpensePerDay = table.Column<decimal>(nullable: true),
                    HousekeepingAndLaundryExpensePerDay = table.Column<decimal>(nullable: true),
                    MedicaidDays = table.Column<int>(nullable: true),
                    MedicaidDaysPercent = table.Column<decimal>(nullable: true),
                    MedicaidRevenuePerDay = table.Column<decimal>(nullable: true),
                    MedicareDays = table.Column<int>(nullable: true),
                    MedicareDaysPercent = table.Column<decimal>(nullable: true),
                    MedicareRevenuePerDay = table.Column<decimal>(nullable: true),
                    NetIncomePerDay = table.Column<decimal>(nullable: true),
                    NetIncomePerRevenuePercent = table.Column<decimal>(nullable: true),
                    NursingCareExpensePerDay = table.Column<decimal>(nullable: true),
                    NursingOccupancyPercent = table.Column<decimal>(nullable: true),
                    OtherComprehensiveDays = table.Column<int>(nullable: true),
                    OtherComprehensiveDaysPercent = table.Column<decimal>(nullable: true),
                    OtherComprehensiveRevenuePerDay = table.Column<decimal>(nullable: true),
                    OtherPatientCareExpensePerDay = table.Column<decimal>(nullable: true),
                    OtherRevenuePerDay = table.Column<decimal>(nullable: true),
                    PrivateDays = table.Column<int>(nullable: true),
                    PrivateDaysPercent = table.Column<decimal>(nullable: true),
                    PrivateRevenuePerDay = table.Column<decimal>(nullable: true),
                    PropertyExpensePerDay = table.Column<decimal>(nullable: true),
                    RealEstateTaxPerDay = table.Column<decimal>(nullable: true),
                    TotalExpensePerDay = table.Column<decimal>(nullable: true),
                    TotalRevenuePerDay = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountyAverage", x => new { x.CountyCode, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    FiscalEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    OperatingDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    CountyCode = table.Column<int>(nullable: false),
                    CountyName = table.Column<string>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<long>(nullable: false),
                    State = table.Column<string>(type: "nchar", nullable: false),
                    Street = table.Column<string>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.PIN);
                });
            migrationBuilder.CreateTable(
                name: "NursingCareService",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    ContractedService = table.Column<int>(nullable: false),
                    EmployeeBenefits = table.Column<int>(nullable: false),
                    OtherAdjustments = table.Column<int>(nullable: false),
                    OtherCosts = table.Column<int>(nullable: false),
                    Payroll = table.Column<int>(nullable: false),
                    Supply = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NursingCareService", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "OperationsSummary",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    AdministrativeServiceAdjustedExpense = table.Column<int>(nullable: false),
                    AdministrativeServiceBookExpense = table.Column<int>(nullable: false),
                    BeforeIncomeTaxNetIncome = table.Column<int>(nullable: false),
                    CapitalOrPropertyServiceAdjusedExpense = table.Column<int>(nullable: false),
                    CapitalOrPropertyServiceBookExpense = table.Column<int>(nullable: false),
                    CapitalValueRentalAdjustedExpense = table.Column<int>(nullable: false),
                    CapitalValueRentalBookExpense = table.Column<int>(nullable: false),
                    GrossOperatingProfit = table.Column<int>(nullable: false),
                    IncomeTaxProvision = table.Column<int>(nullable: false),
                    LessAllowancesAndAdjustmentsRevenue = table.Column<int>(nullable: false),
                    NetRevenue = table.Column<int>(nullable: false),
                    NonOperatingRevenue = table.Column<int>(nullable: false),
                    NonReimbursableExpense = table.Column<int>(nullable: false),
                    NursingCareServiceAdjustedExpense = table.Column<int>(nullable: false),
                    NursingCareServiceBookExpense = table.Column<int>(nullable: false),
                    OtherPatientCareServiceAdjustedExpense = table.Column<int>(nullable: false),
                    OtherPatientCareServiceBookExpense = table.Column<int>(nullable: false),
                    PerFinancialStatementsNetIncome = table.Column<int>(nullable: false),
                    RoutineServiceBookExpense = table.Column<int>(nullable: false),
                    RoutineServiceRevenue = table.Column<int>(nullable: false),
                    RoutingServiceAdjustedExpense = table.Column<int>(nullable: false),
                    SpecialServiceRevenue = table.Column<int>(nullable: false),
                    TotalAdjustedOperatingExpense = table.Column<int>(nullable: false),
                    TotalBookOperatingExpense = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsSummary", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "PatientCareService",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    BarberAndBeautyShopPayroll = table.Column<int>(nullable: false),
                    EmployeeBenefit = table.Column<int>(nullable: false),
                    LaboratoryContractedService = table.Column<int>(nullable: true),
                    LaboratoryPayroll = table.Column<int>(nullable: true),
                    LaboratorySupply = table.Column<int>(nullable: true),
                    MedicalDirectorContractedService = table.Column<int>(nullable: false),
                    MedicalDirectorPayroll = table.Column<int>(nullable: false),
                    MedicalDirectorSupply = table.Column<int>(nullable: false),
                    OccupationalTherapyContractedService = table.Column<int>(nullable: false),
                    OccupationalTherapyPayroll = table.Column<int>(nullable: false),
                    OccupationalTherapySupply = table.Column<int>(nullable: false),
                    Other = table.Column<int>(nullable: false),
                    OtherAdjustment = table.Column<int>(nullable: false),
                    OxygenContractedService = table.Column<int>(nullable: false),
                    OxygenPayroll = table.Column<int>(nullable: false),
                    OxygenSupply = table.Column<int>(nullable: false),
                    PatientCareContractedService = table.Column<int>(nullable: false),
                    PatientCarePayroll = table.Column<int>(nullable: false),
                    PatientCareSupply = table.Column<int>(nullable: false),
                    PharmacyContractedService = table.Column<int>(nullable: false),
                    PharmacyOverTheCounterDrugs = table.Column<int>(nullable: false),
                    PharmacyPayroll = table.Column<int>(nullable: false),
                    PharmacySupply = table.Column<int>(nullable: false),
                    PhysicalTherapyContractedService = table.Column<int>(nullable: false),
                    PhysicalTherapyPayroll = table.Column<int>(nullable: false),
                    PhysicalTherapySupply = table.Column<int>(nullable: false),
                    RadiologyContractedService = table.Column<int>(nullable: true),
                    RadiologyPayroll = table.Column<int>(nullable: true),
                    RadiologySupply = table.Column<int>(nullable: true),
                    RawFood = table.Column<int>(nullable: false),
                    RecreationContractedService = table.Column<int>(nullable: false),
                    RecreationPayroll = table.Column<int>(nullable: false),
                    RecreationSupply = table.Column<int>(nullable: false),
                    ReligiousServiceContractedService = table.Column<int>(nullable: false),
                    ReligiousServiceOther = table.Column<int>(nullable: false),
                    ReligiousServicePayroll = table.Column<int>(nullable: false),
                    ReligiousServiceSupply = table.Column<int>(nullable: false),
                    ReligiousServiceTotal = table.Column<int>(nullable: false),
                    SocialServiceContractedService = table.Column<int>(nullable: false),
                    SocialServiceOther = table.Column<int>(nullable: false),
                    SocialServicePayroll = table.Column<int>(nullable: false),
                    SocialServiceSupply = table.Column<int>(nullable: false),
                    SocialServiceTotal = table.Column<int>(nullable: false),
                    SpeechTherapyContractedService = table.Column<int>(nullable: true),
                    SpeechTherapyPayroll = table.Column<int>(nullable: true),
                    SpeechTherapySupply = table.Column<int>(nullable: true),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCareService", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "RoutineService",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    DietaryAdjustment = table.Column<int>(nullable: false),
                    DietaryBenefit = table.Column<decimal>(type: "numeric", nullable: true),
                    DietaryContractedService = table.Column<int>(nullable: false),
                    DietaryOther = table.Column<int>(nullable: false),
                    DietaryPayroll = table.Column<int>(nullable: false),
                    DietarySupply = table.Column<int>(nullable: false),
                    DietaryTotal = table.Column<int>(nullable: false),
                    EmployeeBenefit = table.Column<int>(nullable: false),
                    HousekeepingAdjustment = table.Column<int>(nullable: false),
                    HousekeepingAndLaundryBenefit = table.Column<decimal>(type: "numeric", nullable: true),
                    HousekeepingContractService = table.Column<int>(nullable: false),
                    HousekeepingOther = table.Column<int>(nullable: false),
                    HousekeepingPayroll = table.Column<int>(nullable: false),
                    HousekeepingSupply = table.Column<int>(nullable: false),
                    HousekeepingTotal = table.Column<int>(nullable: false),
                    LaundryAdjustment = table.Column<int>(nullable: false),
                    LaundryContractedService = table.Column<int>(nullable: false),
                    LaundryLinenReplacement = table.Column<int>(nullable: false),
                    LaundryOther = table.Column<int>(nullable: false),
                    LaundryPayroll = table.Column<int>(nullable: false),
                    LaundrySupply = table.Column<int>(nullable: false),
                    LaundryTotal = table.Column<int>(nullable: false),
                    MainenanceMinorEquipment = table.Column<int>(nullable: false),
                    MaintenanceAdjustment = table.Column<int>(nullable: false),
                    MaintenanceContractedService = table.Column<int>(nullable: false),
                    MaintenanceOther = table.Column<int>(nullable: false),
                    MaintenancePayroll = table.Column<int>(nullable: false),
                    MaintenanceRepair = table.Column<int>(nullable: false),
                    MaintenanceSupply = table.Column<int>(nullable: false),
                    MaintenanceTotal = table.Column<int>(nullable: false),
                    MaintenanceUtility = table.Column<int>(nullable: false),
                    PropertyBenefit = table.Column<decimal>(type: "numeric", nullable: true),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutineService", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "RoutineServiceRevenue",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    ComprehensiveCareCustom1Name = table.Column<string>(nullable: true),
                    ComprehensiveCareCustom1PatientDays = table.Column<int>(nullable: false),
                    ComprehensiveCareCustom1Revenue = table.Column<int>(nullable: false),
                    ComprehensiveCareCustom2Name = table.Column<string>(nullable: true),
                    ComprehensiveCareCustom2PatientDays = table.Column<int>(nullable: false),
                    ComprehensiveCareCustom2Revenue = table.Column<int>(nullable: false),
                    ComprehensiveCareCustom3Name = table.Column<string>(nullable: true),
                    ComprehensiveCareCustom3PatientDays = table.Column<int>(nullable: false),
                    ComprehensiveCareCustom3Revenue = table.Column<int>(nullable: false),
                    ComprehensiveCareMedicaidPatientDays = table.Column<int>(nullable: false),
                    ComprehensiveCareMedicaidRevenue = table.Column<int>(nullable: false),
                    ComprehensiveCareMedicarePatientDays = table.Column<int>(nullable: false),
                    ComprehensiveCareMedicareRevenue = table.Column<int>(nullable: false),
                    ComprehensiveCareOtherPatientDaysTotal = table.Column<int>(nullable: true),
                    ComprehensiveCareOtherRevenueTotal = table.Column<int>(nullable: true),
                    ComprehensiveCarePatientDaysTotal = table.Column<int>(nullable: true),
                    ComprehensiveCarePrivatePatientDays = table.Column<int>(nullable: false),
                    ComprehensiveCarePrivateRevenue = table.Column<int>(nullable: false),
                    ComprehensiveCareRevenueTotal = table.Column<int>(nullable: true),
                    OtherCareCustom1Name = table.Column<string>(nullable: true),
                    OtherCareCustom1PatientDays = table.Column<int>(nullable: false),
                    OtherCareCustom1Revenue = table.Column<int>(nullable: false),
                    OtherCareCustom2Name = table.Column<string>(nullable: true),
                    OtherCareCustom2PatientDays = table.Column<int>(nullable: false),
                    OtherCareCustom2Revenue = table.Column<int>(nullable: false),
                    OtherCareCustom3Name = table.Column<string>(nullable: true),
                    OtherCareCustom3PatientDays = table.Column<int>(nullable: false),
                    OtherCareCustom3Revenue = table.Column<int>(nullable: false),
                    OtherCareCustom4Name = table.Column<string>(nullable: true),
                    OtherCareCustom4PatientDays = table.Column<int>(nullable: false),
                    OtherCareCustom4Revenue = table.Column<int>(nullable: false),
                    OtherCareCustom5Name = table.Column<string>(nullable: true),
                    OtherCareCustom5PatientDays = table.Column<int>(nullable: false),
                    OtherCareCustom5Revenue = table.Column<int>(nullable: false),
                    OtherCareCustom6Name = table.Column<string>(nullable: true),
                    OtherCareCustom6PatientDays = table.Column<int>(nullable: false),
                    OtherCareCustom6Revenue = table.Column<int>(nullable: false),
                    OtherCareCustom7Name = table.Column<string>(nullable: true),
                    OtherCareCustom7PatientDays = table.Column<int>(nullable: false),
                    OtherCareCustom7Revenue = table.Column<int>(nullable: false),
                    OtherCarePatientDaysTotal = table.Column<int>(nullable: true),
                    OtherCareRevenueTotal = table.Column<int>(nullable: true),
                    RevenueTotal = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutineServiceRevenue", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "StateAverage",
                columns: table => new
                {
                    State = table.Column<string>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    ComprehensiveDays = table.Column<int>(nullable: true),
                    ComprehensiveRevenuePerDay = table.Column<decimal>(nullable: true),
                    DietaryExpensePerDay = table.Column<decimal>(nullable: true),
                    GovernmentAndAdministrativeExpensePerDay = table.Column<decimal>(nullable: true),
                    HousekeepingAndLaundryExpensePerDay = table.Column<decimal>(nullable: true),
                    MedicaidDays = table.Column<int>(nullable: true),
                    MedicaidDaysPercent = table.Column<decimal>(nullable: true),
                    MedicaidRevenuePerDay = table.Column<decimal>(nullable: true),
                    MedicareDays = table.Column<int>(nullable: true),
                    MedicareDaysPercent = table.Column<decimal>(nullable: true),
                    MedicareRevenuePerDay = table.Column<decimal>(nullable: true),
                    NetIncomePerDay = table.Column<decimal>(nullable: true),
                    NetIncomePerRevenuePercent = table.Column<decimal>(nullable: true),
                    NursingCareExpensePerDay = table.Column<decimal>(nullable: true),
                    NursingOccupancyPercent = table.Column<decimal>(nullable: true),
                    OtherComprehensiveDays = table.Column<int>(nullable: true),
                    OtherComprehensiveDaysPercent = table.Column<decimal>(nullable: true),
                    OtherComprehensiveRevenuePerDay = table.Column<decimal>(nullable: true),
                    OtherPatientCareExpensePerDay = table.Column<decimal>(nullable: true),
                    OtherRevenuePerDay = table.Column<decimal>(nullable: true),
                    PrivateDays = table.Column<int>(nullable: true),
                    PrivateDaysPercent = table.Column<decimal>(nullable: true),
                    PrivateRevenuePerDay = table.Column<decimal>(nullable: true),
                    PropertyExpensePerDay = table.Column<decimal>(nullable: true),
                    RealEstateTaxPerDay = table.Column<decimal>(nullable: true),
                    TotalExpensePerDay = table.Column<decimal>(nullable: true),
                    TotalRevenuePerDay = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateAverage", x => new { x.State, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    AvailableComprehensiveDays = table.Column<int>(nullable: false),
                    ComprehensiveMedicaidPercent = table.Column<double>(nullable: true),
                    ComprehensiveOccupancyPercent = table.Column<double>(nullable: false),
                    MedicaidComprehensiveDays = table.Column<int>(nullable: false),
                    MedicareComprehensiveDays = table.Column<int>(nullable: false),
                    PrivatePayComprehensiveDays = table.Column<int>(nullable: false),
                    TotalComprehensiveDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => new { x.PIN, x.FiscalYear });
                });
            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    PIN = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    AvailableDays = table.Column<int>(nullable: true),
                    CertifiedBedCount = table.Column<int>(nullable: true),
                    ComprehensiveCareCustom1InsuranceDays = table.Column<int>(nullable: false),
                    ComprehensiveCareCustom2InsuranceDays = table.Column<int>(nullable: false),
                    ComprehensiveCareCustom3InsuranceDays = table.Column<int>(nullable: false),
                    ComprehensiveDailyCensus = table.Column<decimal>(nullable: true),
                    ComprehensiveDays = table.Column<int>(nullable: true),
                    ComprehensivePayor1DailyCensus = table.Column<decimal>(nullable: true),
                    ComprehensivePayor1DailyCensusPercent = table.Column<decimal>(nullable: false),
                    ComprehensivePayor1Days = table.Column<int>(nullable: false),
                    ComprehensivePayor1Name = table.Column<string>(nullable: true),
                    ComprehensivePayor1Revenue = table.Column<decimal>(nullable: true),
                    ComprehensivePayor1RevenuePerDay = table.Column<decimal>(nullable: false),
                    ComprehensivePayor2DailyCensus = table.Column<decimal>(nullable: true),
                    ComprehensivePayor2DailyCensusPercent = table.Column<decimal>(nullable: false),
                    ComprehensivePayor2Days = table.Column<int>(nullable: false),
                    ComprehensivePayor2Name = table.Column<string>(nullable: true),
                    ComprehensivePayor2Revenue = table.Column<decimal>(nullable: true),
                    ComprehensivePayor2RevenuePerDay = table.Column<decimal>(nullable: false),
                    ComprehensivePayor3DailyCensus = table.Column<decimal>(nullable: true),
                    ComprehensivePayor3DailyCensusPercent = table.Column<decimal>(nullable: false),
                    ComprehensivePayor3Days = table.Column<int>(nullable: false),
                    ComprehensivePayor3Name = table.Column<string>(nullable: true),
                    ComprehensivePayor3Revenue = table.Column<decimal>(nullable: true),
                    ComprehensivePayor3RevenuePerDay = table.Column<decimal>(nullable: false),
                    ComprehensiveRevenue = table.Column<int>(nullable: true),
                    ComprehensiveRevenuePerDay = table.Column<decimal>(nullable: false),
                    ComprehensiveRevenuePercent = table.Column<decimal>(nullable: true),
                    DietaryExpense = table.Column<decimal>(nullable: true),
                    DietaryExpensePerDay = table.Column<decimal>(nullable: false),
                    DietaryExpensePerRevenuePercent = table.Column<decimal>(nullable: true),
                    GovernmentAndAdministrativeExpense = table.Column<int>(nullable: true),
                    GovernmentAndAdministrativeExpensePerDay = table.Column<decimal>(nullable: false),
                    GovernmentAndAdministrativeExpensePerRevenuePercent = table.Column<decimal>(nullable: true),
                    HousekeepingAndLaundryExpense = table.Column<decimal>(nullable: true),
                    HousekeepingAndLaundryExpensePerDay = table.Column<decimal>(nullable: false),
                    HousekeepingAndLaundryExpensePerRevenuePercent = table.Column<decimal>(nullable: true),
                    ImpliedMaxValue = table.Column<decimal>(nullable: true),
                    ImpliedMaxValuePerBed = table.Column<decimal>(nullable: true),
                    ImpliedMinValue = table.Column<decimal>(nullable: true),
                    ImpliedMinValuePerBed = table.Column<decimal>(nullable: true),
                    MedicaidDailyCensus = table.Column<decimal>(nullable: true),
                    MedicaidDays = table.Column<int>(nullable: false),
                    MedicaidDaysPercent = table.Column<decimal>(nullable: true),
                    MedicaidRevenue = table.Column<int>(nullable: true),
                    MedicaidRevenuePerDay = table.Column<decimal>(nullable: false),
                    MedicareDailyCensus = table.Column<decimal>(nullable: true),
                    MedicareDays = table.Column<int>(nullable: false),
                    MedicareDaysPercent = table.Column<decimal>(nullable: true),
                    MedicareRevenue = table.Column<decimal>(nullable: true),
                    MedicareRevenuePerDay = table.Column<decimal>(nullable: false),
                    NetIncome = table.Column<decimal>(nullable: true),
                    NetIncomePerBed = table.Column<decimal>(nullable: true),
                    NetIncomePerDay = table.Column<decimal>(nullable: false),
                    NetIncomePerRevenuePercent = table.Column<decimal>(nullable: true),
                    NursingCareExpense = table.Column<int>(nullable: true),
                    NursingCareExpensePerDay = table.Column<decimal>(nullable: false),
                    NursingCareExpensePerRevenuePercent = table.Column<decimal>(nullable: true),
                    NursingOccupancyPercent = table.Column<decimal>(nullable: true),
                    OperatingDays = table.Column<int>(nullable: false),
                    OtherCareDays = table.Column<int>(nullable: true),
                    OtherComprehensiveDailyCensus = table.Column<decimal>(nullable: true),
                    OtherComprehensiveDays = table.Column<int>(nullable: true),
                    OtherComprehensiveDaysPercent = table.Column<decimal>(nullable: true),
                    OtherComprehensiveRevenue = table.Column<decimal>(nullable: true),
                    OtherComprehensiveRevenuePerDay = table.Column<decimal>(nullable: false),
                    OtherPatientCareExpense = table.Column<int>(nullable: false),
                    OtherPatientCareExpensePerDay = table.Column<decimal>(nullable: false),
                    OtherPatientCareExpensePerRevenuePercent = table.Column<decimal>(nullable: true),
                    OtherRevenue = table.Column<int>(nullable: true),
                    OtherRevenuePerDay = table.Column<decimal>(nullable: false),
                    OtherRevenuePercent = table.Column<decimal>(nullable: true),
                    PrivateDailyCensus = table.Column<decimal>(nullable: true),
                    PrivateDays = table.Column<int>(nullable: false),
                    PrivateDaysPercent = table.Column<decimal>(nullable: true),
                    PrivateRevenue = table.Column<int>(nullable: false),
                    PrivateRevenuePerDay = table.Column<decimal>(nullable: false),
                    PropertyExpense = table.Column<decimal>(nullable: true),
                    PropertyExpensePerDay = table.Column<decimal>(nullable: false),
                    PropertyExpensePerRevenuePercent = table.Column<decimal>(nullable: true),
                    RealEstateTax = table.Column<int>(nullable: false),
                    RealEstateTaxPerDay = table.Column<decimal>(nullable: false),
                    RealEstateTaxPerRevenuePercent = table.Column<decimal>(nullable: true),
                    SpecialServiceRevenue = table.Column<int>(nullable: false),
                    TotalDays = table.Column<int>(nullable: true),
                    TotalExpense = table.Column<decimal>(nullable: true),
                    TotalExpensePerDay = table.Column<decimal>(nullable: false),
                    TotalExpensePerRevenuePercent = table.Column<decimal>(nullable: true),
                    TotalRevenue = table.Column<int>(nullable: true),
                    TotalRevenuePerDay = table.Column<decimal>(nullable: false),
                    UnadjustedComprehensivePayor1Revenue = table.Column<int>(nullable: false),
                    UnadjustedComprehensivePayor2Revenue = table.Column<int>(nullable: false),
                    UnadjustedComprehensivePayor3Revenue = table.Column<int>(nullable: false),
                    UnadjustedMedicareRevenue = table.Column<int>(nullable: true),
                    UnadjustedOtherComprehensiveRevenue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => new { x.PIN, x.FiscalYear });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("AdministrativeService");
            migrationBuilder.DropTable("AdministrativeServiceOther");
            migrationBuilder.DropTable("AllowanceAndAdjustmentsToRevenue");
            migrationBuilder.DropTable("AncillaryRevenue");
            migrationBuilder.DropTable("CapitalPropertyService");
            migrationBuilder.DropTable("CountyAverage");
            migrationBuilder.DropTable("Description");
            migrationBuilder.DropTable("Home");
            migrationBuilder.DropTable("NursingCareService");
            migrationBuilder.DropTable("OperationsSummary");
            migrationBuilder.DropTable("PatientCareService");
            migrationBuilder.DropTable("RoutineService");
            migrationBuilder.DropTable("RoutineServiceRevenue");
            migrationBuilder.DropTable("StateAverage");
            migrationBuilder.DropTable("Statistics");
            migrationBuilder.DropTable("Summary");
        }
    }
}
