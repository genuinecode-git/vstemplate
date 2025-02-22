using ILogger = Serilog.ILogger;

namespace Application.API.Extentions.ExtentionHelpers;

public class ExceptionHandler(RequestDelegate next, ILogger logger)
{
    private readonly RequestDelegate _next = next;
    private readonly ILogger _logger = logger;

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Unhandled exception occurred");

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            var response = new { message = ex.Message };
            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
