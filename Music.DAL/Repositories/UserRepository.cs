using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.EF;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;
using System.Numerics;

namespace MusicPortal.DAL.Repositories
{
    public class UserRepository(MusicContext db) : IRepository<Users>
    {
        public async Task<IEnumerable<Users>> GetAll()
        {
            return await db.User.ToListAsync();
        }

        public async Task<Users?> Get(int id)
        {
            return await db.User.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Users?> Get(string name)
        {
            return await db.User.FirstOrDefaultAsync(a => a.FirstName == name);
        }

        public async Task Create(Users user) => await db.User.AddAsync(user);

        public void Update(Users user) => db.Entry(user).State = EntityState.Modified;

        public async Task Delete(int id)
        {
            Users? user = await db.User.FindAsync(id);
            if (user != null)
            {
                db.User.Remove(user);
            }
        }
    }
}
