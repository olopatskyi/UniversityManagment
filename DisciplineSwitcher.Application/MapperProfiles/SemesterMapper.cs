using AutoMapper;
using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Domain.Entities;

namespace DisciplineSwitcher.Application.MapperProfiles;

public class SemesterMapper : Profile
{
    public SemesterMapper()
    {
        CreateMap<CreateSemesterVm, Semester>(MemberList.Source)
            .AfterMap((src, dest) =>
            {
                dest.EndDate = src.EndDate.ToUniversalTime();
                dest.StartDate = src.StartDate.ToUniversalTime();
            });
    }
}