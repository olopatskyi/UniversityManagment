using System.Reflection;
using DisciplineSwitcher.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DisciplineSwitcher.Infrastructure.DataAccess;

public class DatabaseContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    
    public DbSet<Semester> Semesters { get; set; }

    public DbSet<Faculty> Faculties { get; set; }
    
    public DbSet<Group> Groups { get; set; }
    
    public DbSet<Discipline> Disciplines { get; set; }
    
    public DbSet<Teacher> Teachers { get; set; }

    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(DatabaseContext))!);
        
        base.OnModelCreating(builder);
    }
}