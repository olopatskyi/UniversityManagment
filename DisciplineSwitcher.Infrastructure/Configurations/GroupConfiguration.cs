using DisciplineSwitcher.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DisciplineSwitcher.Infrastructure.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasMany(x => x.Students)
            .WithOne(x => x.Group)
            .HasForeignKey(x => x.GroupId);

        builder.HasOne(x => x.Faculty)
            .WithMany(x=>x.Groups)
            .HasForeignKey(x=>x.FacultyId);
    }
}