using AutoMapper;
using DisciplineSwitcher.Application.Models.Response;
using DisciplineSwitcher.Domain.Entities;

namespace DisciplineSwitcher.Application.MapperProfiles;

public class StudentMapperProfile : Profile
{
    public StudentMapperProfile()
    {
        CreateMap<Student, StudentVm>(MemberList.Destination)
            .AfterMap((src, dest) =>
            {
                dest.Name = src.UserName!;
            });
    }
}