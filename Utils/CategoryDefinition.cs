using budget_api.Enums;

namespace budget_api.Utils;

public record CategoryDefinition(
    string Name,
    CategoryGroup Group,
    TransactionType Type);