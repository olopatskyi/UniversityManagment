using DisciplineSwitcher.Domain.Interfaces;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Application.Extensions;

public static class ExceptionExtensions
{
    public static AppResponse CreateWithOneMessage(this AppResponse response, IAppException exception)
    {
        return new AppResponse()
        {
            StatusCode = exception.StatusCode,
            Errors = exception.Errors.Select(x => new AppError(null, x))
        };
    }
}