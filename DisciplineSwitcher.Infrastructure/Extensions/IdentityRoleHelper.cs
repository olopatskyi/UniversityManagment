using Microsoft.AspNetCore.Identity;

namespace DisciplineSwitcher.Infrastructure.Extensions;

public static class IdentityRoleHelper
{
    private static int _id = 1;
    
    private static Dictionary<string, string[]> AdminScopes = new()
    {
        { "student", new[] { "get", "create", "delete", "update" } },
        { "teacher", new[] { "get", "create", "delete", "update" } },
        { "discipline", new[] { "get", "create", "delete", "update" } },
        { "faculty", new[] { "get", "create", "delete", "update" } },
        { "semester", new[] { "get", "create", "delete", "update" } },
        { "group", new[] { "get", "create", "delete" } }
    };

    private static Dictionary<string, string[]> StudentScopes = new()
    {
        { "student", new[] { "get", "create", "delete", "update" } },
        { "teacher", new[] { "get" } },
        { "discipline", new[] { "get" } },
        { "faculty", new[] { "get" } },
        { "semester", new[] { "get" } },
        { "group", new[] { "get" } }
    };

    private static Dictionary<string, string[]> TeacherScopes = new()
    {
        { "student", new[] { "get", "update" } },
        { "teacher", new[] { "get", "create", "update", "delete" } },
        { "discipline", new[] { "get", "create", "update", "delete" } },
        { "faculty", new[] { "get" } },
        { "semester", new[] { "get" } },
        { "group", new[] { "get", "create", "update", "delete" } }
    };

    internal static IEnumerable<IdentityRoleClaim<Guid>> GetAdminPermissionsScope()
    {
        var roleClaims = new List<IdentityRoleClaim<Guid>>();

        foreach (var entityPermission in AdminScopes)
        {
            var entity = entityPermission.Key;
            var permissions = entityPermission.Value;

            foreach (var permission in permissions)
            {
                var claim = new IdentityRoleClaim<Guid>
                {
                    Id = _id,
                    RoleId = Guid.Parse("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"),
                    ClaimType = $"{permission}:{entity}",
                };

                roleClaims.Add(claim);
                _id++;
            }
        }

        return roleClaims;
    }

    internal static IEnumerable<IdentityRoleClaim<Guid>> GetStudentPermissionScope()
    {
        var roleClaims = new List<IdentityRoleClaim<Guid>>();

        foreach (var entityPermission in StudentScopes)
        {
            var entity = entityPermission.Key;
            var permissions = entityPermission.Value;

            foreach (var permission in permissions)
            {
                var claim = new IdentityRoleClaim<Guid>
                {
                    Id = _id,
                    RoleId = Guid.Parse("7a7231fb-fe42-40df-bf8b-1adcb564a136"),
                    ClaimType = $"{permission}:{entity}",
                };

                roleClaims.Add(claim);
                _id++;
            }
        }

        return roleClaims;
    }

    internal static IEnumerable<IdentityRoleClaim<Guid>> GetTeacherPermissionScope()
    {
        var roleClaims = new List<IdentityRoleClaim<Guid>>();

        foreach (var entityPermission in TeacherScopes)
        {
            var entity = entityPermission.Key;
            var permissions = entityPermission.Value;

            foreach (var permission in permissions)
            {
                var claim = new IdentityRoleClaim<Guid>
                {
                    Id = _id,
                    RoleId = Guid.Parse("104adc6e-eb7e-40ee-832c-64b2198b0e6f"),
                    ClaimType = $"{permission}:{entity}",
                };

                roleClaims.Add(claim);
                _id++;
            }
        }

        return roleClaims;
    }
}