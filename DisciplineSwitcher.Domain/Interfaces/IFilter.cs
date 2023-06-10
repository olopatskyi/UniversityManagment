using DisciplineSwitcher.Domain.Entities;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Domain.Interfaces;

public interface IFilter<TEntity>
{
    IQueryable<TEntity> ApplyFilter(DataFilter filter, IQueryable<TEntity> query);
}