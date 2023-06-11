using System.Net;
using DisciplineSwitcher.Application.Interfaces;
using DisciplineSwitcher.Application.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace DisciplineSwitcher.WebApi.Controllers;

[ApiController]
[Route("api/v1/faculty")]
public class FacultyController : ControllerBase
{
    private readonly IFacultyService _facultyService;

    public FacultyController(IFacultyService facultyService)
    {
        _facultyService = facultyService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateFacultyVm model)
    {
        var result = await _facultyService.CreateAsync(model);
        return result.StatusCode switch
        {
            (int)HttpStatusCode.Created => Ok(result),
            (int)HttpStatusCode.Conflict => Conflict(result),
        };
    }
}