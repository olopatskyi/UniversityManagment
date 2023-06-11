using DisciplineSwitcher.Application.Interfaces;
using DisciplineSwitcher.Application.Services;
using DisciplineSwitcher.Application.Shared;
using DisciplineSwitcher.Domain.Entities;
using DisciplineSwitcher.Infrastructure.DataAccess;
using DisciplineSwitcher.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace DisciplineSwitcher.Application.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentity(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddIdentityCore<IdentityUser<Guid>>(x =>
            {
                x.User.RequireUniqueEmail = true;
                x.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -._";
            })
            .AddRoles<IdentityRole<Guid>>()
            .AddSignInManager<SignInManager<IdentityUser<Guid>>>()
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();
        
        serviceCollection.AddIdentityCore<Student>()
            .AddRoles<IdentityRole<Guid>>()
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();

        serviceCollection.AddIdentityCore<Teacher>()
            .AddRoles<IdentityRole<Guid>>()
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();


        return serviceCollection;
    }

    public static IServiceCollection AddMapper(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddAutoMapper(typeof(JwtSettings));

        return serviceCollection;
    }
    
    public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<UserManager<IdentityUser<Guid>>>();
        serviceCollection.AddScoped<UserManager<Student>>();
        serviceCollection.AddScoped<UserManager<Teacher>>();
        
        serviceCollection.AddScoped<AppRoleManager>();
        
        serviceCollection.AddScoped<IAuthService, AuthService>();
        serviceCollection.AddScoped<IDisciplineService, DisciplineService>();
        serviceCollection.AddScoped<ISemesterService, SemesterService>();
        serviceCollection.AddScoped<IGroupService, GroupService>();
        serviceCollection.AddScoped<IFacultyService, FacultyService>();
        serviceCollection.AddSingleton<IPermissionService, PermissionService>();

        return serviceCollection;
    }

    public static IServiceCollection AddObservers(this IServiceCollection serviceCollection)
    {
        return serviceCollection;
    }
}