namespace Learn_ASP.NET_Core.MiddelWares
{
    public class RateLimittingMiddelWare
    {
        private readonly RequestDelegate _next;

        private static int _counter = 0;
        private static DateTime _lastRequestDate = DateTime.Now;


        public RateLimittingMiddelWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext next)
        {
            _counter++;
            if (DateTime.Now.Subtract(_lastRequestDate).Seconds > 10)
            {
                _counter = 1;
                _lastRequestDate = DateTime.Now;
            }
            else
            {
                if (_counter > 5)
                {
                    _lastRequestDate = DateTime.Now;
                    await next.Response.WriteAsync("Rate Limit Exceeded");
                    return;
                }

                else
                {
                    _lastRequestDate = DateTime.Now;
                    await _next(next);
                }
            }
        }
    }
}
