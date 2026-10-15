using AutoMapper;
using MusicPortal.BLL.DTO;
using MusicPortal.BLL.Infrastructure;
using MusicPortal.BLL.Interfaces;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;


namespace MusicPortal.BLL.Services
{
    public class SongService(IUnitOfWork database, IMapper mapper) : ISongService
    {
        public async Task CreateSong(SongDTO songDto)
        {
            var song = new Song
            {
                Id = songDto.Id,
                NameOfSong = songDto.NameOfSong,
                Foto = songDto.Foto,
                AudioPath = songDto.AudioPath,
                UserId = songDto.UserId,
                SingersId = songDto.SingersId,
                GenreId = songDto.GenreId
            };
            await database.Song.Create(song);
            await database.Save();
        }

        public async Task UpdateSong(SongDTO songDto)
        {
            var song = new Song
            {
                Id = songDto.Id,
                NameOfSong = songDto.NameOfSong,
                Foto = songDto.Foto,
                AudioPath = songDto.AudioPath,
                UserId = songDto.UserId,
                SingersId = songDto.SingersId,
                GenreId = songDto.GenreId
            };
            database.Song.Update(song);
            await database.Save();
        }

        public async Task DeleteSong(int id)
        {
            await database.Song.Delete(id);
            await database.Save();
        }

        public async Task<SongDTO> GetSong(int id)
        {
            var song = await database.Song.Get(id);
            if (song == null)
                throw new ValidationException("Дані відсутні!", nameof(id));

            return mapper.Map<SongDTO>(song);
        }

        public async Task<IEnumerable<SongDTO>> GetSongs()
        {
            var songs = await database.Song.GetAll();
            return mapper.Map<IEnumerable<SongDTO>>(songs);
        }

        public Task<IEnumerable<SongDTO>> GetAllSongs()
        {
            throw new NotImplementedException();
        }
    }
}
