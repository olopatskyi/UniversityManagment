namespace DisciplineSwitcher.Domain.Interfaces;

public interface IAppException
{
    int StatusCode { get; }

    IEnumerable<string> Errors { get; }
}