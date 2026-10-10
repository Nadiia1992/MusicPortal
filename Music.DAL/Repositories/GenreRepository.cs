using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.EF;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;

namespace MusicPortal.DAL.Repositories
{
    public class GenreRepository(MusicContext db) : IRepository<Genres>
    {
        public async Task<IEnumerable<Genres>> GetAll()
        {
            return await db.Genres.ToListAsync();
        }

        public async Task<Genres?> Get(int id)
        {
            return await db.Genres.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Genres?> Get(string name)
        {
            return await db.Genres.FirstOrDefaultAsync(a => a.Genre == name);
        }

        public async Task Create(Genres genre) => await db.Genres.AddAsync(genre);

        public void Update(Genres genre) => db.Entry(genre).State = EntityState.Modified;

        public async Task Delete(int id)
        {
            Genres? genre = await db.Genres.FindAsync(id);
            if (genre != null)
            {
                db.Genres.Remove(genre);
            }
        }
    }
}
