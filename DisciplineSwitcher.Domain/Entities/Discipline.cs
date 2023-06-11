namespace DisciplineSwitcher.Domain.Entities;

public class Discipline : BaseEntity
{
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid TeacherId { get; set; }
    public Guid SemesterId { get; set; }


    public Teacher? Teacher { get; set; }
    public Semester? Semester { get; set; }

    public ICollection<Student>? Students { get; set; }
}