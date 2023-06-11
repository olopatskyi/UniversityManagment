using DisciplineSwitcher.Domain.Entities;

namespace DisciplineSwitcher.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRepository<Group> GroupRepository { get; }
    IRepository<Discipline> DisciplineRepository { get; }
    
    IRepository<StudentDiscipline> StudentDisciplineRepository { get; }
    IRepository<Faculty> FacultyRepository { get; }

    IRepository<Semester> SemesterRepository { get; }
    Task SaveAsync();
}