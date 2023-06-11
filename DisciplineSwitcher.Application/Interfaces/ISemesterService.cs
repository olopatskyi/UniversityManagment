using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Application.Interfaces;

public interface ISemesterService
{
    Task<AppResponse> CreateAsync(CreateSemesterVm model);
}