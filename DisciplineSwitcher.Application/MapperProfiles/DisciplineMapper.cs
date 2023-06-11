using AutoMapper;
using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Application.Models.Response;
using DisciplineSwitcher.Domain.Entities;

namespace DisciplineSwitcher.Application.MapperProfiles;

public class DisciplineMapper : Profile
{
    public DisciplineMapper()
    {
        CreateMap<CreateDisciplineVm, Discipline>(MemberList.Source);
        CreateMap<Discipline, DisciplineVm>(MemberList.Destination)
            .AfterMap((src, dest) =>
            {
                dest.TeacherName = src.Teacher?.UserName!;
            });
    }
}