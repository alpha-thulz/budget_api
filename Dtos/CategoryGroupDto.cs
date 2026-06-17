using budget_api.Enums;
using budget_api.Utils;

namespace budget_api.Dtos;

public record CategoryGroupDto(
    CategoryGroup Group,
    IEnumerable<CategoryDefinition> Categories);