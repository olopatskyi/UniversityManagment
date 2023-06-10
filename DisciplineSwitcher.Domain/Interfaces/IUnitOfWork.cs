using DisciplineSwitcher.Domain.Entities;

namespace DisciplineSwitcher.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task SaveAsync();
}