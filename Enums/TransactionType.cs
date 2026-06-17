using System.Text.Json.Serialization;

namespace budget_api.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TransactionType
{
    Income = 1,
    Expense,
    Transfer
}