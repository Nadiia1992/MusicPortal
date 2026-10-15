using AutoMapper;
using MusicPortal.DAL.Interfaces;
using MusicPortal.BLL.DTO;
using MusicPortal.BLL.Infrastructure;
using MusicPortal.BLL.Interfaces;
using MusicPortal.DAL.Entities;

namespace MusicPortal.BLL.Services
{
    public class SingerService(IUnitOfWork database, IMapper mapper) : ISingerService
    {
        public async Task CreateSinger(SingerDTO singerDto)
        {
            var singer = new Singers
            {
                Id = singerDto.Id,
                Singer = singerDto.Singer,
                Image = singerDto.Image

            };
            await database.Singer.Create(singer);
            await database.Save();
        }

        public async Task UpdateSinger(SingerDTO singerDto)
        {
            var singer = new Singers
            {
                Id = singerDto.Id,
                Singer = singerDto.Singer,
                Image = singerDto.Image
            };
            database.Singer.Update(singer);
            await database.Save();
        }

        public async Task DeleteSinger(int id)
        {
            await database.Singer.Delete(id);
            await database.Save();
        }

        public async Task<SingerDTO> GetSinger(int id)
        {
            var singer = await database.Singer.Get(id);
            if (singer == null)
                throw new ValidationException("Дані відсутні!", nameof(id));

            return mapper.Map<SingerDTO>(singer);
        }

        public async Task<IEnumerable<SingerDTO>> GetAllSingers()
        {
            var singers = await database.Singer.GetAll();
            return mapper.Map<IEnumerable<SingerDTO>>(singers);
        }
    }
}

