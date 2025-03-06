using System.Diagnostics;

namespace Learn_ASP.NET_Core.MiddelWares
{
    public class ProfillingMiddelWares
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ProfillingMiddelWares> _logger;
        public ProfillingMiddelWares(ILogger<ProfillingMiddelWares> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;

        }

        public async Task InvokeAsync(HttpContext context)
        {
            var watch = new Stopwatch();
            watch.Start();
            await _next(context);
            watch.Stop();
            _logger.LogInformation($"Request Time: {watch.ElapsedMilliseconds} ms");



        }
    }
}
