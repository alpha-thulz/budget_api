using BudgetApi.Dtos;
using BudgetApi.Utils;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MetadataController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<CategoryDefinition>> GetCategories()
    {
        return Ok(CategoryCatalog.Categories.Values.OrderBy(c => c.Group));
    }
    
    [HttpGet("grouped")]
    public ActionResult<IEnumerable<CategoryGroupDto>> GetGroupedCategories()
    {
        var result = CategoryCatalog.Categories.Values
            .GroupBy(c => c.Group)
            .Select(g => new CategoryGroupDto(
                g.Key,
                g.OrderBy(x => x.Name)))
            .OrderBy(x => x.Group);

        return Ok(result);
    }
    
    [HttpGet("group/{group}")]
    public ActionResult<IEnumerable<CategoryDefinition>> GetCategoriesByGroup(string group)
    {
        var grouped = CategoryCatalog.Categories.Values
            .Where(c => string.Equals(c.Group.ToString(), group, StringComparison.CurrentCultureIgnoreCase))
            .OrderBy(c => c.Name);
        
        return Ok(grouped);
    }
}