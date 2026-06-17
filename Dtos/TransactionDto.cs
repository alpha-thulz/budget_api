using budget_api.Utils;

namespace budget_api.Dtos;

public class TransactionDto
{
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public CategoryDefinition CategoryDefinition { get; set; } = CategoryCatalog.Categories["Uncategorized"];
    public DateOnly TransactionDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
}