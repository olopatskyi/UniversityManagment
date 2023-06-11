using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Application.Models.Response;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Application.Interfaces;

public interface IDisciplineService
{
    Task<AppResponse<IEnumerable<DisciplineVm>>> GetTeacherDisciplines(Guid teacherId);

    Task<AppResponse<IEnumerable<DisciplineVm>>> GetStudentDisciplines(Guid studentId);
    
    Task<AppResponse> CreateAsync(Guid requesterId, CreateDisciplineVm model);

    Task<AppResponse> EnrollAsync(Guid studentId, Guid disciplineId);
}