using Microsoft.AspNetCore.Builder;

namespace TestWebApplication
{
    public static class TokenExtensions
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string pattern = "1")
        {
            return builder.UseMiddleware<TokenMiddleware>(pattern);
        }
    }
}
