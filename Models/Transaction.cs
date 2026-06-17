using budget_api.Utils;

namespace budget_api.Models;

public class Transaction
{
    public required string Guid { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Amount { get; set; }
    public CategoryDefinition CategoryDefinition { get; set; } = CategoryCatalog.Categories["Uncategorized"];
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateOnly TransactionDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
}