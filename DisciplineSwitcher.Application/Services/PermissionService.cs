using Microsoft.AspNetCore.Http;
using DisciplineSwitcher.Application.Interfaces;
namespace DisciplineSwitcher.Application.Services;

public class PermissionService : IPermissionService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public PermissionService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public bool CanGetGroup => HasPermission("get:group");
    public bool CanCreateGroup => HasPermission("create:group");
    public bool CanDeleteGroup => HasPermission("delete:group");
    public bool CanUpdateGroup => HasPermission("update:group");

    public bool CanGetStudent => HasPermission("get:student");
    public bool CanCreateStudent => HasPermission("create:student");
    public bool CanDeleteStudent => HasPermission("delete:student");
    public bool CanUpdateStudent => HasPermission("update:student");

    public bool CanGetTeacher => HasPermission("get:teacher");
    public bool CanCreateTeacher => HasPermission("create:teacher");
    public bool CanDeleteTeacher => HasPermission("delete:teacher");
    public bool CanUpdateTeacher => HasPermission("update:teacher");

    public bool CanGetDiscipline => HasPermission("get:discipline");
    public bool CanCreateDiscipline => HasPermission("create:discipline");
    public bool CanDeleteDiscipline => HasPermission("delete:discipline");
    public bool CanUpdateDiscipline => HasPermission("update:discipline");

    public bool CanGetFaculty => HasPermission("get:faculty");
    public bool CanCreateFaculty => HasPermission("create:faculty");
    public bool CanDeleteFaculty => HasPermission("delete:faculty");
    public bool CanUpdateFaculty => HasPermission("update:faculty");
    
    public bool CanGetSemester => HasPermission("get:semester");
    public bool CanCreateSemester => HasPermission("create:semester");
    public bool CanDeleteSemester => HasPermission("delete:semester");
    public bool CanUpdateSemester => HasPermission("update:semester");
    
    private bool HasPermission(string permission)
    {
        var scopes = _httpContextAccessor.HttpContext.User.Claims
            .Where(c => c.Type == "scopes")
            .SelectMany(c => c.Value.Split(','));

        return scopes.Contains(permission);
    }
}