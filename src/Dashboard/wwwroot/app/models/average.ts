import {Model} from './model'
export class Average extends Model {
    fiscalYear: number
    privateDays: number
    privateDaysPercent: number
    medicareDays: number
    medicareDaysPercent: number
    medicaidDays: number
    medicaidDaysPercent: number
    otherComprehensiveDays: number
    otherComprehensiveDaysPercent: number
    comprehensiveDays: number
    nursingOccupancyPercent: number
    privateRevenuePerDay: number
    medicareRevenuePerDay: number
    medicaidRevenuePerDay: number
    otherComprehensiveRevenuePerDay: number
    comprehensiveRevenuePerDay: number
    totalRevenuePerDay: number
    otherRevenuePerDay: number
    governmentAndAdministrativeExpensePerDay: number
    dietaryExpensePerDay: number
    housekeepingAndLaundryExpensePerDay: number
    nursingCareExpensePerDay: number
    otherPatientCareExpensePerDay: number
    propertyExpensePerDay: number
    realEstateTaxPerDay: number
    totalExpensePerDay: number
    netIncomePerDay: number
    netIncomePerRevenuePercent: number
}