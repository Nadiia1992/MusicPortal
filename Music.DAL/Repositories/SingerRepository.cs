using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.EF;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;


namespace MusicPortal.DAL.Repositories
{
    public class SingerRepository(MusicContext db) : IRepository<Singers>
    {
        public async Task<IEnumerable<Singers>> GetAll()
        {
            return await db.Singers.ToListAsync();
        }

        public async Task<Singers?> Get(int id)
        {
            return await db.Singers.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Singers?> Get(string name)
        {
            return await db.Singers.FirstOrDefaultAsync(a => a.Singer == name);
        }

        public async Task Create(Singers singer) => await db.Singers.AddAsync(singer);

        public void Update(Singers singer) => db.Entry(singer).State = EntityState.Modified;

        public async Task Delete(int id)
        {
            Singers? singer = await db.Singers.FindAsync(id);
            if (singer != null)
            {
                db.Singers.Remove(singer);
            }
        }
    }
}
