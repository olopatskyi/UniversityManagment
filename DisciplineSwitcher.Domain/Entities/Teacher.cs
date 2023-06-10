using Microsoft.AspNetCore.Identity;

namespace DisciplineSwitcher.Domain.Entities;

public class Teacher : IdentityUser<Guid>
{
    public ICollection<Group>? Groups { get; set; }
}