namespace DisciplineSwitcher.Application.Models.Requests;

public class CreateGroupVm
{
    public string Name { get; set; } = null!;

    public Guid FacultyId { get; set; }
}