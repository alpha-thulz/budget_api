using BudgetApi.Models;
using BudgetApi.Utils;

namespace BudgetApi.Dtos;

public record CategoryGroupDto(
    CategoryGroup Group,
    IEnumerable<CategoryDefinition> Categories);