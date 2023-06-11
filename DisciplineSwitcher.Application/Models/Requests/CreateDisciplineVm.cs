namespace DisciplineSwitcher.Application.Models.Requests;

public class CreateDisciplineVm
{
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;
    
    public Guid SemesterId { get; set; }
}