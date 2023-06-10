namespace DisciplineSwitcher.Domain.Entities;

public class Discipline : BaseEntity
{
    public string Title { get; set; } = null!;

    public Guid SemesterId { get; set; }


    public Semester? Semester { get; set; }

    public ICollection<Group>? Groups { get; set; }
}