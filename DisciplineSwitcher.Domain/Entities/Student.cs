using Microsoft.AspNetCore.Identity;

namespace DisciplineSwitcher.Domain.Entities;

public class Student : IdentityUser<Guid>
{
    public Guid? GroupId { get; set; }
    
    public Group? Group { get; set; }
}