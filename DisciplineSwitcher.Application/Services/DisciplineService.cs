using System.Net;
using AutoMapper;
using DisciplineSwitcher.Application.Interfaces;
using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Application.Models.Response;
using DisciplineSwitcher.Domain.Entities;
using DisciplineSwitcher.Domain.Exceptions;
using DisciplineSwitcher.Domain.Interfaces;
using DisciplineSwitcher.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;

namespace DisciplineSwitcher.Application.Services;

public class DisciplineService : IDisciplineService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly UserManager<Student> _userManager;

    public DisciplineService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Student> userManager)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<AppResponse<IEnumerable<DisciplineVm>>> GetTeacherDisciplines(Guid teacherId)
    {
        var disciplines =
            await _unitOfWork.DisciplineRepository.GetAsync(x => x.TeacherId == teacherId, nameof(Discipline.Teacher));
        return new AppResponse<IEnumerable<DisciplineVm>>(HttpStatusCode.OK, null,
            _mapper.Map<IEnumerable<DisciplineVm>>(disciplines));
    }

    public async Task<AppResponse<IEnumerable<DisciplineVm>>> GetStudentDisciplines(Guid studentId)
    {
        var student = await _userManager.Users.Include(x => x.Disciplines).AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == studentId);

        if (student == null)
        {
            throw NotFoundException.Default<Student>();
        }
        
        return new AppResponse<IEnumerable<DisciplineVm>>(HttpStatusCode.OK, null,
            _mapper.Map<IEnumerable<DisciplineVm>>(student.Disciplines));
    }

    public async Task<AppResponse> EnrollAsync(Guid studentId, Guid disciplineId)
    {
        var discipline = await _unitOfWork.DisciplineRepository.FirstOrDefaultAsync(x => x.Id == disciplineId);
        if (discipline == null)
        {
            throw NotFoundException.Default<Discipline>();
        }

        var student = await _userManager.FindByIdAsync(studentId.ToString());
        if (student == null)
        {
            throw NotFoundException.Default<Student>();
        }

        await _unitOfWork.StudentDisciplineRepository.CreateAsync(new StudentDiscipline()
        {
            StudentId = studentId,
            DisciplineId = disciplineId,
            Status = EnrollStatus.Sent
        });
        await _unitOfWork.SaveAsync();

        return new AppResponse(HttpStatusCode.OK, null);
    }

    public async Task<AppResponse> CreateAsync(Guid requesterId, CreateDisciplineVm model)
    {
        var entity =
            await _unitOfWork.DisciplineRepository.FirstOrDefaultAsync(x =>
                x.TeacherId == requesterId && x.Title == model.Title);
        if (entity != null)
        {
            throw new ValidationException("Discipline has already create");
        }

        entity = _mapper.Map<Discipline>(model);
        entity.TeacherId = requesterId;

        await _unitOfWork.DisciplineRepository.CreateAsync(entity!);
        await _unitOfWork.SaveAsync();

        return new AppResponse(HttpStatusCode.Created, null);
    }
}