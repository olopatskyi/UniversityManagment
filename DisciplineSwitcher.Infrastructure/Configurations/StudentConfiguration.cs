using DisciplineSwitcher.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DisciplineSwitcher.Infrastructure.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students");
        
        builder.HasOne(x => x.Group)
            .WithMany(x => x.Students)
            .HasForeignKey(x => x.GroupId);
        
        PasswordHasher<Student> hasher = new PasswordHasher<Student>();
        
        builder.HasData(new Student()
        {
            Id = Guid.Parse("537826d9-90b5-4d70-9606-addbd078d509"),
            UserName = "Artur Bondar",
            Email = "artur.bondar@gmail.com",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            PasswordHash = hasher.HashPassword(null, "Artur_1"),
        });
    }
}