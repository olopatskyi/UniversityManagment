using System.Linq.Expressions;
using DisciplineSwitcher.Domain.Entities;
using DisciplineSwitcher.Domain.Interfaces;
using DisciplineSwitcher.Domain.Models;
using DisciplineSwitcher.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DisciplineSwitcher.Infrastructure.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly DbSet<TEntity> DbSet;
    private readonly DatabaseContext _databaseContext;
    
    public Repository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        DbSet = databaseContext.Set<TEntity>();
    }

    public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression, params string[] includes)
    {
        IQueryable<TEntity> query = DbSet;

        if (includes.Any())
        {
            foreach (var property in includes)
            {
                query = query.Include(property);
            }
        }
        
        return await query.AsNoTracking().FirstOrDefaultAsync(expression);
    }

    public async Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await DbSet.AnyAsync(expression);
    }

    public async Task CreateAsync(TEntity entity)
    {
        await DbSet.AddAsync(entity);
    }

    public void Delete(TEntity entity)
    {
        DbSet.Remove(entity);
    }

    public void Update(TEntity entity)
    {
        DbSet.Update(entity);
    }

    public async Task AddRangeAsync(IEnumerable<TEntity> entities)
    {
        await DbSet.AddRangeAsync(entities);
    }

    public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? expression, params string[] includes)
    {
        IQueryable<TEntity> query = DbSet;
        
        if (expression == null)
        {
            query = query.Where(_ => true);
        }
        else
        {
            query = query.Where(expression);
        }

        if (includes.Any())
        {
            foreach (var prop in includes)
            {
                query = query.Include(prop);
            }
        }
        
        return await query.AsNoTracking().ToListAsync();
    }
}
