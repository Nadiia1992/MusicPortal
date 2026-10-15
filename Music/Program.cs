using MusicPortal.BLL.Interfaces;
using MusicPortal.BLL.Services;
using MusicPortal.BLL.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
if (connection != null)
{
    builder.Services.AddSoccerContext(connection);
}

builder.Services.AddUnitOfWorkService();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ISingerService, SingerService>();
builder.Services.AddTransient<ISongService, SongService>();
builder.Services.AddTransient<IGenreService, GenreService>();
builder.Services.AddMusicAutoMapper();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Teams}/{action=Index}/{id?}");

app.Run();
