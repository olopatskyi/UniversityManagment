using AutoMapper;
using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DisciplineSwitcher.Application.MapperProfiles;

public class AppUserMapper : Profile
{
    public AppUserMapper()
    {
        CreateMap<SignUpVm, IdentityUser<Guid>>(MemberList.Source)
            .AfterMap((src, dest) =>
            {
                dest.EmailConfirmed = true;
                dest.PhoneNumberConfirmed = true;
                dest.UserName = $"{src.FirstName.ToLower()[0]}{src.LastName.ToLower()}";
            });
    }
}