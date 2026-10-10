using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.EF;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;

namespace MusicPortal.DAL.Repositories
{
    public class SongRepository(MusicContext db) : IRepository<Song>
    {
        public async Task<IEnumerable<Song>> GetAll()
        {
            return await db.Songs.Include(s => s.Singer).ToListAsync();
        }

        public async Task<Song?> Get(int id)
        {
            return await db.Songs.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Song?> Get(string name)
        {
            return await db.Songs.FirstOrDefaultAsync(a => a.NameOfSong == name);
        }

        public async Task Create(Song song) => await db.Songs.AddAsync(song);

        public void Update(Song song) => db.Entry(song).State = EntityState.Modified;

        public async Task Delete(int id)
        {
            Song? song = await db.Songs.FindAsync(id);
            if (song != null)
            {
                db.Songs.Remove(song);
            }
        }
    }
}
