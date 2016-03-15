import {Model} from './model'
export class FinanceView extends Model {
    PIN: number
    FiscalYear: number
    Name: string
    City: string
    Street: string
    State: string
    Occupancy: number
    Beds: number
    Revenue: number
    Expense: number
    Income: number
    ProfitMargin: number
    MedicareRevenuePerDay: number
}