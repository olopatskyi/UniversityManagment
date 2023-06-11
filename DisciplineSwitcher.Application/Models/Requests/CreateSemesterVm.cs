namespace DisciplineSwitcher.Application.Models.Requests;

public class CreateSemesterVm
{
    public int Number { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}