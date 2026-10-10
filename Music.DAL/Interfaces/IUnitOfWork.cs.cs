using MusicPortal.DAL.Entities;
using System.Numerics;

namespace MusicPortal.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Users> User { get; }
        IRepository<Singers> Singer { get; }
        IRepository<Genres> Genre { get; }
        IRepository<Song> Song { get; }

        Task Save();
    }
}
