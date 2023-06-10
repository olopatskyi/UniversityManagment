using DisciplineSwitcher.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DisciplineSwitcher.Infrastructure.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasMany(x => x.Groups)
            .WithMany(x => x.Teachers);

        PasswordHasher<IdentityUser<Guid>> hasher = new PasswordHasher<IdentityUser<Guid>>();
        
        builder.HasData(new Teacher
        {
            Id = Guid.Parse("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"),
            UserName = "Volodymyr Tymofiyovych",
            Email = "volodymyr.tymofiyovych@gmail.com",
            EmailConfirmed = true,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            SecurityStamp = Guid.NewGuid().ToString(),
            PhoneNumberConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Volodya_1")
        });
    }
}