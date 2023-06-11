using DisciplineSwitcher.Application.Interfaces;
using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.WebApi.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DisciplineSwitcher.WebApi.Controllers;

[ApiController]
[Route("api/v1/discilines")]
[Authorize]
public class DisciplinesController : ControllerBase
{
    private readonly IDisciplineService _disciplineService;
    public DisciplinesController(IDisciplineService disciplineService)
    {
        _disciplineService = disciplineService;
    }

    [HttpGet("/api/v1/student/disciplines")]
    public async Task<IActionResult> GetStudentDisciplinesAsync()
    {
        var result = await _disciplineService.GetStudentDisciplines(HttpContext.GetUserId());
        return Ok(result);
    }

    [HttpGet("/api/v1/teacher/disciplines")]
    public async Task<IActionResult> GetTeacherDisciplines()
    {
        var result = await _disciplineService.GetTeacherDisciplines(HttpContext.GetUserId());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateDisciplineVm model)
    {
        var result = await _disciplineService.CreateAsync(HttpContext.GetUserId(), model);
        return Created("api/v1/disciplines", result);
    }

    [HttpPost("{id}/enroll")]
    public async Task<IActionResult> EnrollAsync(Guid id)
    {
        var result = await _disciplineService.EnrollAsync(HttpContext.GetUserId(), id);
        return Ok(result);
    }
}