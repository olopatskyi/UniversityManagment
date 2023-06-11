using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Application.Interfaces;

public interface IFacultyService
{
    Task<AppResponse> CreateAsync(CreateFacultyVm model);
}