using AutoMapper;
using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Domain.Entities;

namespace DisciplineSwitcher.Application.MapperProfiles;

public class GroupMapperProfile : Profile
{
    public GroupMapperProfile()
    {
        CreateMap<CreateGroupVm, Group>(MemberList.Source);
    }
}