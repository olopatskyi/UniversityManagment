using Microsoft.AspNetCore.Mvc;

namespace DisciplineSwitcher.WebApi.Controllers;

[ApiController]
[Route("api/v1/students")]
public class StudentsController : ControllerBase
{
    [HttpGet("profile")]
    public async Task<IActionResult> GetProfileAsync()
    {
        return Ok();
    }
    
    [HttpGet()]
    [HttpPatch("assing/{groupId}")]
    public async Task<IActionResult> AssignToGroupAsync(Guid groupId)
    {
        return Ok();
    }

}