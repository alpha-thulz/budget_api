using BudgetApi.Enums;
using BudgetApi.Models;

namespace BudgetApi.Utils;

public static class CategoryCatalog
{
    public static readonly IReadOnlyDictionary<string, CategoryDefinition> Categories =
        new Dictionary<string, CategoryDefinition>
        {
            // Income
            ["Salary"] = new("Salary", CategoryGroup.Income, TransactionType.Income),
            ["Bonus"] = new("Bonus", CategoryGroup.Income, TransactionType.Income),
            ["Commission"] = new("Commission", CategoryGroup.Income, TransactionType.Income),
            ["Overtime"] = new("Overtime", CategoryGroup.Income, TransactionType.Income),
            ["Freelance"] = new("Freelance", CategoryGroup.Income, TransactionType.Income),
            ["Consulting"] = new("Consulting", CategoryGroup.Income, TransactionType.Income),
            ["BusinessIncome"] = new("BusinessIncome", CategoryGroup.Income, TransactionType.Income),
            ["InvestmentIncome"] = new("InvestmentIncome", CategoryGroup.Income, TransactionType.Income),
            ["Dividends"] = new("Dividends", CategoryGroup.Income, TransactionType.Income),
            ["Interest"] = new("Interest", CategoryGroup.Income, TransactionType.Income),
            ["RentalIncome"] = new("RentalIncome", CategoryGroup.Income, TransactionType.Income),
            ["GiftReceived"] = new("GiftReceived", CategoryGroup.Income, TransactionType.Income),
            ["TaxRefund"] = new("TaxRefund", CategoryGroup.Income, TransactionType.Income),
            ["OtherIncome"] = new("OtherIncome", CategoryGroup.Income, TransactionType.Income),

            // Housing
            ["Rent"] = new("Rent", CategoryGroup.Housing, TransactionType.Expense),
            ["Mortgage"] = new("Mortgage", CategoryGroup.Housing, TransactionType.Expense),
            ["Electricity"] = new("Electricity", CategoryGroup.Housing, TransactionType.Expense),
            ["Water"] = new("Water", CategoryGroup.Housing, TransactionType.Expense),
            ["Gas"] = new("Gas", CategoryGroup.Housing, TransactionType.Expense),
            ["RefuseRemoval"] = new("RefuseRemoval", CategoryGroup.Housing, TransactionType.Expense),
            ["RatesAndTaxes"] = new("RatesAndTaxes", CategoryGroup.Housing, TransactionType.Expense),
            ["HomeInsurance"] = new("HomeInsurance", CategoryGroup.Housing, TransactionType.Expense),
            ["HomeMaintenance"] = new("HomeMaintenance", CategoryGroup.Housing, TransactionType.Expense),
            ["Security"] = new("Security", CategoryGroup.Housing, TransactionType.Expense),
            ["BodyCorporate"] = new("BodyCorporate", CategoryGroup.Housing, TransactionType.Expense),

            // Food
            ["Groceries"] = new("Groceries", CategoryGroup.Food, TransactionType.Expense),
            ["DiningOut"] = new("DiningOut", CategoryGroup.Food, TransactionType.Expense),
            ["Takeaways"] = new("Takeaways", CategoryGroup.Food, TransactionType.Expense),
            ["Coffee"] = new("Coffee", CategoryGroup.Food, TransactionType.Expense),
            ["Snacks"] = new("Snacks", CategoryGroup.Food, TransactionType.Expense),
            ["FastFood"] = new("FastFood", CategoryGroup.Food, TransactionType.Expense),
            ["FoodDelivery"] = new("FoodDelivery", CategoryGroup.Food, TransactionType.Expense),

            // Transport
            ["Petrol"] = new("Petrol", CategoryGroup.Transport, TransactionType.Expense),
            ["PublicTransport"] = new("PublicTransport", CategoryGroup.Transport, TransactionType.Expense),
            ["Taxi"] = new("Taxi", CategoryGroup.Transport, TransactionType.Expense),
            ["RideSharing"] = new("RideSharing", CategoryGroup.Transport, TransactionType.Expense),
            ["Parking"] = new("Parking", CategoryGroup.Transport, TransactionType.Expense),
            ["Tolls"] = new("Tolls", CategoryGroup.Transport, TransactionType.Expense),
            ["VehicleInsurance"] = new("VehicleInsurance", CategoryGroup.Transport, TransactionType.Expense),
            ["VehicleMaintenance"] = new("VehicleMaintenance", CategoryGroup.Transport, TransactionType.Expense),
            ["VehicleLicense"] = new("VehicleLicense", CategoryGroup.Transport, TransactionType.Expense),
            ["CarWash"] = new("CarWash", CategoryGroup.Transport, TransactionType.Expense),

            // Healthcare
            ["MedicalAid"] = new("MedicalAid", CategoryGroup.Healthcare, TransactionType.Expense),
            ["Doctor"] = new("Doctor", CategoryGroup.Healthcare, TransactionType.Expense),
            ["Specialist"] = new("Specialist", CategoryGroup.Healthcare, TransactionType.Expense),
            ["Pharmacy"] = new("Pharmacy", CategoryGroup.Healthcare, TransactionType.Expense),
            ["Dental"] = new("Dental", CategoryGroup.Healthcare, TransactionType.Expense),
            ["Vision"] = new("Vision", CategoryGroup.Healthcare, TransactionType.Expense),
            ["Hospital"] = new("Hospital", CategoryGroup.Healthcare, TransactionType.Expense),
            ["MentalHealth"] = new("MentalHealth", CategoryGroup.Healthcare, TransactionType.Expense),
            ["Physiotherapy"] = new("Physiotherapy", CategoryGroup.Healthcare, TransactionType.Expense),
            ["Fitness"] = new("Fitness", CategoryGroup.Healthcare, TransactionType.Expense),
            ["Gym"] = new("Gym", CategoryGroup.Healthcare, TransactionType.Expense),

            // Financial
            ["Savings"] = new("Savings", CategoryGroup.Financial, TransactionType.Expense),
            ["Investments"] = new("Investments", CategoryGroup.Financial, TransactionType.Expense),
            ["Retirement"] = new("Retirement", CategoryGroup.Financial, TransactionType.Expense),
            ["EmergencyFund"] = new("EmergencyFund", CategoryGroup.Financial, TransactionType.Expense),
            ["BankFees"] = new("BankFees", CategoryGroup.Financial, TransactionType.Expense),
            ["LoanRepayment"] = new("LoanRepayment", CategoryGroup.Financial, TransactionType.Expense),
            ["CreditCardPayment"] = new("CreditCardPayment", CategoryGroup.Financial, TransactionType.Expense),
            ["Taxes"] = new("Taxes", CategoryGroup.Financial, TransactionType.Expense),
            ["LifeInsurance"] = new("LifeInsurance", CategoryGroup.Financial, TransactionType.Expense),
            ["DebtRepayment"] = new("DebtRepayment", CategoryGroup.Financial, TransactionType.Expense),

            // Other
            ["Transfer"] = new("Transfer", CategoryGroup.Other, TransactionType.Transfer),
            ["CashWithdrawal"] = new("CashWithdrawal", CategoryGroup.Other, TransactionType.Expense),
            ["Miscellaneous"] = new("Miscellaneous", CategoryGroup.Other, TransactionType.Expense),
            ["Uncategorized"] = new("Uncategorized", CategoryGroup.Other, TransactionType.Expense),
            ["Unknown"] = new("Unknown", CategoryGroup.Other, TransactionType.Expense),
            ["Adjustment"] = new("Adjustment", CategoryGroup.Other, TransactionType.Expense)
        };
}