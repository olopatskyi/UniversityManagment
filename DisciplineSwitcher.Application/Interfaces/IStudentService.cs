using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Application.Interfaces;

public interface IStudentService
{
    Task<AppResponse> CreateAsync();
}