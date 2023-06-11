using DisciplineSwitcher.Application.Interfaces;
using DisciplineSwitcher.Application.Models.Requests;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/semesters")]
public class SemestersController : ControllerBase
{
    private readonly ISemesterService _semesterService;

    public SemestersController(ISemesterService semesterService)
    {
        _semesterService = semesterService;
    }

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
    public async Task<IActionResult> CreateSemester([FromBody] CreateSemesterVm model)
    {
        var result = await _semesterService.CreateAsync(model);
        return Created("api/v1/semesters", result);
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