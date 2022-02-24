using Microsoft.AspNetCore.Mvc.Filters;

namespace MusicEvents.Security.API.Filters;

public class MusicFilterErrors : IExceptionFilter
{
    private readonly ILogger<MusicFilterErrors> _logger;

    public MusicFilterErrors(ILogger<MusicFilterErrors> logger)
    {
        _logger = logger;
    }

    public void OnException(ExceptionContext context)
    {
        _logger.LogError($"{context.HttpContext.Request.Path} provocó el error {context.Exception.Message} {context.Exception.StackTrace}");
    }

}
