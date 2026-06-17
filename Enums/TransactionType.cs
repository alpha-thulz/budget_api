using System.Text.Json.Serialization;

namespace BudgetApi.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TransactionType
{
    Income = 1,
    Expense,
    Transfer
}