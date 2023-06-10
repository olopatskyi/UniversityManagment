namespace DisciplineSwitcher.Application.Interfaces;

public interface IPermissionService
{
    bool CanGetGroup { get; }

    bool CanCreateGroup { get; }

    bool CanDeleteGroup { get; }

    bool CanUpdateGroup { get; }

    bool CanGetStudent { get; }

    bool CanCreateStudent { get; }

    bool CanDeleteStudent { get; }

    bool CanUpdateStudent { get; }

    bool CanGetTeacher { get; }

    bool CanCreateTeacher { get; }

    bool CanDeleteTeacher { get; }

    bool CanUpdateTeacher { get; }

    bool CanGetDiscipline { get; }

    bool CanCreateDiscipline { get; }

    bool CanDeleteDiscipline { get; }

    bool CanUpdateDiscipline { get; }

    bool CanGetFaculty { get; }

    bool CanCreateFaculty { get; }

    bool CanDeleteFaculty { get; }

    bool CanUpdateFaculty { get; }

    bool CanGetSemester { get; }

    bool CanCreateSemester { get; }

    bool CanDeleteSemester { get; }

    bool CanUpdateSemester { get; }
}