using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Application.Models.Response;
using DisciplineSwitcher.Domain.Entities;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Application.Interfaces;

public interface IGroupService
{
    Task<AppResponse<Group>> GetGroupByIdAsync(Guid groupId);

    Task<AppResponse<IEnumerable<StudentVm>>> GetStudentsAsync(Guid groupId);
    
    Task<AppResponse> CreateAsync(CreateGroupVm model);

    Task<AppResponse> AddToGroupAsync(Guid groupId, Guid studentId);
}