using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DisciplineSwitcher.WebApi.Controllers;

[ApiController]
[Route("api/v1/discilines")]
[Authorize]
public class DisciplinesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetDisciplinesAsync()
    {
        return Ok();
    }
}