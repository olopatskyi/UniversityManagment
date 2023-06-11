using System.Net;
using DisciplineSwitcher.Application.Interfaces;
using DisciplineSwitcher.Domain.Entities;
using DisciplineSwitcher.Domain.Exceptions;
using DisciplineSwitcher.Domain.Interfaces;
using DisciplineSwitcher.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace DisciplineSwitcher.Application.Services;

public class StudentService : IStudentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<Student> _userManager;

    public StudentService(IUnitOfWork unitOfWork, UserManager<Student> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public Task<AppResponse> CreateAsync()
    {
        throw new NotImplementedException();
    }
    
}