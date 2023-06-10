using DisciplineSwitcher.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DisciplineSwitcher.WebApi.Controllers;

[ApiController]
[Route("api/v1/groups")]
public class GroupsController : ControllerBase
{
    private readonly IPermissionService _permissionService;

    public GroupsController(IPermissionService permissionService)
    {
        _permissionService = permissionService;
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        if (!_permissionService.CanGetGroup)
        {
            return Forbid();
        }

        return Ok();
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateAsync()
    {
        if (!_permissionService.CanCreateGroup)
        {
            return Forbid();
        }
        
        return Created("api/v1/groups", null);
    }
}