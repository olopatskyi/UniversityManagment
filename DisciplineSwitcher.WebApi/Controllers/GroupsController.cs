using DisciplineSwitcher.Application.Interfaces;
using DisciplineSwitcher.Application.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DisciplineSwitcher.WebApi.Controllers;

[ApiController]
[Route("api/v1/groups")]
public class GroupsController : ControllerBase
{
    private readonly IPermissionService _permissionService;
    private readonly IGroupService _groupService;

    public GroupsController(IPermissionService permissionService, IGroupService groupService)
    {
        _permissionService = permissionService;
        _groupService = groupService;
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        if (!_permissionService.CanGetGroup)
        {
            return Forbid();
        }

        var result = await _groupService.GetGroupByIdAsync(id);
        return Ok(result);
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateGroupVm model)
    {
        if (!_permissionService.CanCreateGroup)
        {
            return Forbid();
        }

        var result = await _groupService.CreateAsync(model);
        return Created("api/v1/groups", result);
    }

    [Authorize]
    [HttpPut("{groupId}/add/{studentId}")]
    public async Task<IActionResult> AddStudentToGroupAsync(Guid groupId, Guid studentId)
    {
        var result = await _groupService.AddToGroupAsync(groupId, studentId);
        return Ok(result);
    }

    [HttpGet("{id}/students")]
    public async Task<IActionResult> GetStudentsAsync(Guid id)
    {
        var result = await _groupService.GetStudentsAsync(id);
        return Ok(result);
    }

}