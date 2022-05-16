namespace BlazorServerTestIis.Infrastructure;

public class CountMiddleware
{
    private readonly RequestDelegate _next;
    private static int count = 0;

    public CountMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine($"ID : {count} BEFORE EXECUTE NEXT 🎃");
        await _next(context);
        Console.WriteLine($"ID : {count} AFTER EXECUTE NEXT 👻");
        count++;
    }
}

public static class CountMiddlewareExtensions
{
    public static IApplicationBuilder UseCountMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CountMiddleware>();
    }
}
