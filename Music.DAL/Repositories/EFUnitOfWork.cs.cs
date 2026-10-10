using MusicPortal.DAL.Interfaces;
using MusicPortal.DAL.EF;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;
using System.Numerics;

namespace MusicPortal.DAL.Repositories;

public class EFUnitOfWork(MusicContext db) : IUnitOfWork
{
    private UserRepository? _userRepository;
    private SingerRepository? _singerRepository;
    private GenreRepository? _genreRepository;
    private SongRepository? _songRepository;

    public IRepository<Singers> Singer => _singerRepository ??= new SingerRepository(db);

    public IRepository<Genres> Genre => _genreRepository ??= new GenreRepository(db);

    public IRepository<Song> Song => _songRepository ??= new SongRepository(db);

    public IRepository<Users> User => _userRepository ??= new UserRepository(db);

    public async Task Save() => await db.SaveChangesAsync();
}
