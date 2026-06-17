using BudgetApi.Enums;
using BudgetApi.Models;

namespace BudgetApi.Utils;

public record CategoryDefinition(
    string Name,
    CategoryGroup Group,
    TransactionType Type);