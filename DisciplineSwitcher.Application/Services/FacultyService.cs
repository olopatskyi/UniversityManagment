using System.Net;
using AutoMapper;
using DisciplineSwitcher.Application.Interfaces;
using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Domain.Entities;
using DisciplineSwitcher.Domain.Interfaces;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Application.Services;

public class FacultyService : IFacultyService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FacultyService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<AppResponse> CreateAsync(CreateFacultyVm model)
    {
        var entity = await _unitOfWork.FacultyRepository.FirstOrDefaultAsync(x => x.Name == model.Name);
        if (entity != null)
        {
            return new AppResponse(HttpStatusCode.Conflict, new[] { new AppError(null, "Faculty already exists") });
        }

        entity = _mapper.Map<Faculty>(model);

        await _unitOfWork.FacultyRepository.CreateAsync(entity);
        await _unitOfWork.SaveAsync();

        return new AppResponse(HttpStatusCode.Created, null);
    }
}