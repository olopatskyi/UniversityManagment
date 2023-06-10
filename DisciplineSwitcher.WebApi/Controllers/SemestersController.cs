using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/semesters")]
public class SemestersController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetAllSemesters()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSemesterById(int id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateSemester()
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSemester()
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSemester(int id)
    {
        return Ok();
    }
}