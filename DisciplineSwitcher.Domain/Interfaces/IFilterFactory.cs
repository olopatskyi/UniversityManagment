using DisciplineSwitcher.Domain.Entities;

namespace DisciplineSwitcher.Domain.Interfaces;

public interface IFilterFactory<TEntity> where TEntity : BaseEntity
{
    IFilter<TEntity> GetFilter();
}