using Microsoft.AspNetCore.Mvc;

namespace budget_api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get() => Ok("Server is up and running!");
}