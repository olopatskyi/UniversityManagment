using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Application.Models.Response;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Application.Interfaces;

public interface IAuthService
{
    Task<AppResponse> SignUpAsync(SignUpVm model);
    
    Task<AppResponse<SignInResponse>> SignInAsync(SignInVm model);
}