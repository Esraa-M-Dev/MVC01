using System.Diagnostics;

namespace Assignment01MVC.CustomMiddlewares
{
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            await _next(context);

            stopwatch.Stop();

            Console.WriteLine(
                $"{context.Request.Path} -- {stopwatch.ElapsedMilliseconds} ms"
            );
        }
    }
}
