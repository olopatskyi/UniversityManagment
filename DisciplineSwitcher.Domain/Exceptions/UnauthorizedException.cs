using DisciplineSwitcher.Domain.Interfaces;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Domain.Exceptions;

public class UnauthorizedException : Exception, IAppException
{
    public UnauthorizedException(IEnumerable<string> errors)
    {
        Errors = errors;
    }

    public int StatusCode => 401;
    
    public IEnumerable<string> Errors { get; private set; }
}