using System.Net;
using AutoMapper;
using DisciplineSwitcher.Application.Interfaces;
using DisciplineSwitcher.Application.Models.Requests;
using DisciplineSwitcher.Domain.Entities;
using DisciplineSwitcher.Domain.Exceptions;
using DisciplineSwitcher.Domain.Interfaces;
using DisciplineSwitcher.Domain.Models;

namespace DisciplineSwitcher.Application.Services;

public class SemesterService : ISemesterService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public SemesterService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<AppResponse> CreateAsync(CreateSemesterVm model)
    {
        var entity = await _unitOfWork.SemesterRepository.FirstOrDefaultAsync(x =>
            x.Number == model.Number && x.StartDate == model.StartDate && x.EndDate == model.EndDate);

        if (entity != null)
        {
            throw new ValidationException(new[] { "Semester has already created" });
        }

        entity = _mapper.Map<Semester>(model);
        await _unitOfWork.SemesterRepository.CreateAsync(entity!);
        await _unitOfWork.SaveAsync();

        return new AppResponse(HttpStatusCode.Created, null);
    }
}