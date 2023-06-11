using DisciplineSwitcher.Domain.Entities;
using DisciplineSwitcher.Domain.Interfaces;
using DisciplineSwitcher.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DisciplineSwitcher.Infrastructure.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly IRepository<Group> _groupRepository;
    private readonly IRepository<Discipline> _disciplineRepository;
    private readonly IRepository<Faculty> _facultyRepository;
    private readonly IRepository<Semester> _semesterRepository;
    private readonly IRepository<StudentDiscipline> _studentDisciplineRepository;


    private readonly DatabaseContext _databaseContext;

    public UnitOfWork(IRepository<Group> groupRepository, IRepository<Discipline> disciplineRepository,
        IRepository<Faculty> facultyRepository, IRepository<Semester> semesterRepository,
        DatabaseContext databaseContext, IRepository<StudentDiscipline> studentDisciplineRepository)
    {
        _groupRepository = groupRepository;
        _disciplineRepository = disciplineRepository;
        _facultyRepository = facultyRepository;
        _semesterRepository = semesterRepository;
        _databaseContext = databaseContext;
        _studentDisciplineRepository = studentDisciplineRepository;
    }

    public IRepository<Group> GroupRepository => _groupRepository;

    public IRepository<Discipline> DisciplineRepository => _disciplineRepository;

    public IRepository<Faculty> FacultyRepository => _facultyRepository;

    public IRepository<Semester> SemesterRepository => _semesterRepository;

    public IRepository<StudentDiscipline> StudentDisciplineRepository => _studentDisciplineRepository;

    public async Task SaveAsync()
    {
        await _databaseContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            /*_databaseContext.Dispose();*/
        }
    }
}