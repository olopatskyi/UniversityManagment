namespace DisciplineSwitcher.Domain.Entities;

public class StudentDiscipline : BaseEntity
{
    public Guid DisciplineId { get; set; }
    
    public Guid StudentId { get; set; }

    public EnrollStatus Status { get; set; }
    
    
    public Discipline? Discipline { get; set; }
    
    public Student? Student { get; set; }
}