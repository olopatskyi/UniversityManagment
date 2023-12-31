namespace DisciplineSwitcher.Domain.Entities;

public class Semester : BaseEntity
{
    public int Number { get; set; }
    
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public ICollection<Discipline>? Disciplines { get; set; }
}