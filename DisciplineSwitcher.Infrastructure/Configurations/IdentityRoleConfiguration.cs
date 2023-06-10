using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DisciplineSwitcher.Infrastructure.Configurations;

public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
    {
        builder.HasData(new IdentityRole<Guid>
        {
            Id = Guid.Parse("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"),
            Name = "Admin",
            NormalizedName = "ADMIN",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        }, new IdentityRole<Guid>
        {
            Id = Guid.Parse("7a7231fb-fe42-40df-bf8b-1adcb564a136"),
            Name = "Student",
            NormalizedName = "STUDENT",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        }, new IdentityRole<Guid>
        {
            Id = Guid.Parse("104adc6e-eb7e-40ee-832c-64b2198b0e6f"),
            Name = "Teacher",
            NormalizedName = "TEACHER",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        });
    }
}