using AutoMapper;
using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Domain.Entities;

namespace DisciplineSwitcher.Application.MapperProfiles;

public class FacultyMapperProfile : Profile
{
    public FacultyMapperProfile()
    {
        CreateMap<CreateFacultyVm, Faculty>(MemberList.Source);
    }
}