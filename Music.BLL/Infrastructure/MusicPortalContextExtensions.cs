using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.EF;

namespace MusicPortal.BLL.Infrastructure
{
    public static class SoccerContextExtensions
    {
        public static void AddSoccerContext(this IServiceCollection services, string connection) =>
            services.AddDbContext<MusicContext>(options => options.UseSqlServer(connection));
    }
}
