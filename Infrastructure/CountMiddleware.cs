namespace BlazorServerTestIis.Infrastructure;

public class CountMiddleware
{
    private readonly RequestDelegate _next;

    public CountMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("BEFORE EXECUTE NEXT 🎃");
        await _next(context);
        Console.WriteLine("BEFORE EXECUTE NEXT 👻");
    }
}

public static class CountMiddlewareExtensions
{
    public static IApplicationBuilder UseCountMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CountMiddleware>();
    }
}
