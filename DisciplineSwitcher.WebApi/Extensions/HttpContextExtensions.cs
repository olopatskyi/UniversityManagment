using System.Security.Claims;

namespace DisciplineSwitcher.WebApi.Extensions;

public static class HttpContextExtensions
{
    public static Guid GetUserId(this HttpContext context)
    {
        return Guid.Parse(context.User.Claims.First(x=>x.Type == "Id").Value);
    }
}