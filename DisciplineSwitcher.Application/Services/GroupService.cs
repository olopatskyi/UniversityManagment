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
using Microsoft.AspNetCore.Mvc;

namespace DisciplineSwitcher.Application.Services;

public class GroupService : IGroupService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly UserManager<Student> _userManager;

    public GroupService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Student> userManager)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<AppResponse<Group>> GetGroupByIdAsync(Guid groupId)
    {
        var result = await _unitOfWork.GroupRepository
            .FirstOrDefaultAsync(x => x.Id == groupId, nameof(Group.Students));
        if (result == null)
        {
            throw NotFoundException.Default<Group>();
        }
        
        return new AppResponse<Group>(HttpStatusCode.OK, null, result);
    }

    public async Task<AppResponse<IEnumerable<StudentVm>>> GetStudentsAsync(Guid groupId)
    {
        var group = await _unitOfWork.GroupRepository.FirstOrDefaultAsync(x => x.Id == groupId, nameof(Group.Students));
        if (group == null)
        {
            throw NotFoundException.Default<Group>();
        }

        return new AppResponse<IEnumerable<StudentVm>>(HttpStatusCode.OK, null, _mapper.Map<IEnumerable<StudentVm>>(group.Students));
    }
    public async Task<AppResponse> AddToGroupAsync(Guid groupId, Guid studentId)
    {
        var group = await _unitOfWork.GroupRepository.FirstOrDefaultAsync(x => x.Id == groupId);
        if (group == null)
        {
            throw NotFoundException.Default<Group>();
        }

        var student = await _userManager.FindByIdAsync(studentId.ToString());
        if (student == null)
        {
            throw NotFoundException.Default<Student>();
        }

        student.GroupId = groupId;
        await _unitOfWork.SaveAsync();

        return new AppResponse(HttpStatusCode.OK, null);
    }
    public async Task<AppResponse> CreateAsync(CreateGroupVm model)
    {
        var isExists = await _unitOfWork.GroupRepository.IsExistsAsync(x => x.Name == model.Name);
        if (isExists)
        {
            throw new ValidationException(new[] { "Group with this name already exists" });
        }

        var group = _mapper.Map<Group>(model);
        
        await _unitOfWork.GroupRepository.CreateAsync(group);
        await _unitOfWork.SaveAsync();

        return new AppResponse(HttpStatusCode.Created, null);
    }
}