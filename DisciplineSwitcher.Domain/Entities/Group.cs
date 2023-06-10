namespace DisciplineSwitcher.Domain.Entities;

public class Group : BaseEntity
{
    public string Name { get; set; } = null!;

    public Guid FacultyId { get; set; }


    public Faculty? Faculty { get; set; }
    public ICollection<Student>? Students { get; set; }

    public ICollection<Teacher>? Teachers { get; set; }

    public ICollection<Discipline>? Disciplines { get; set; }
}