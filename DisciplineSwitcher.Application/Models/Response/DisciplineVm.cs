namespace DisciplineSwitcher.Application.Models.Response;

public class DisciplineVm
{
    public Guid Id { get; set; }
    
    public string Title { get; set; } = null!;

    public string TeacherName { get; set; } = null!;
}