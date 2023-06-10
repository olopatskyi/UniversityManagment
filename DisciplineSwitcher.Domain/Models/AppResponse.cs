using System.Net;

namespace DisciplineSwitcher.Domain.Models;

public class AppResponse
{
    public AppResponse()
    {
        
    }
    
    public AppResponse(HttpStatusCode statusCode, IEnumerable<AppError>? errors)
    {
        StatusCode = (int)statusCode;
        Errors = errors;
    }
    
    public int StatusCode { get; set; }
    
    public IEnumerable<AppError>? Errors { get; set; }
}

public class AppResponse<TData> : AppResponse
{
    public AppResponse(HttpStatusCode statusCode, IEnumerable<AppError>? errors, TData data) : base(statusCode, errors)
    {
        Data = data;
    }
    
    public TData Data { get; set; }
}