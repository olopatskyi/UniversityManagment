using DisciplineSwitcher.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DisciplineSwitcher.Infrastructure.Configurations;

public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
{
    public void Configure(EntityTypeBuilder<Discipline> builder)
    {
        builder.HasOne(x => x.Semester)
            .WithMany(x => x.Disciplines)
            .HasForeignKey(x => x.SemesterId);

        builder.HasOne(x => x.Teacher)
            .WithMany(x => x.Disciplines)
            .HasForeignKey(x => x.TeacherId);

        builder.HasMany(x => x.Students)
            .WithMany(x => x.Disciplines);

    }
}