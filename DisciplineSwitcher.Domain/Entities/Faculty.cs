namespace DisciplineSwitcher.Domain.Entities;

public class Faculty : BaseEntity
{
    public string Name { get; set; } = null!;

    public ICollection<Student>? Students { get; set; }

    public ICollection<Teacher>? Teachers { get; set; }
    
    public ICollection<Group>? Groups { get; set; }
}