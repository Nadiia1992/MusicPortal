using Microsoft.Extensions.DependencyInjection;
using MusicPortal.BLL.Profiles;

namespace MusicPortal.BLL.Infrastructure;

public static class AutoMapperServiceExtensions
{
    public static void AddMusicAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg =>
        {
            cfg.AddProfile<MusicProfile>();
        });
    }
}
