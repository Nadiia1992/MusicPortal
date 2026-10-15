using AutoMapper;
using MusicPortal.DAL.Interfaces;
using MusicPortal.BLL.DTO;
using MusicPortal.BLL.Infrastructure;
using MusicPortal.BLL.Interfaces;
using MusicPortal.DAL.Entities;

namespace MusicPortal.BLL.Services
{
    public class GenreService(IUnitOfWork database, IMapper mapper) : IGenreService
    {
        public async Task CreateGenre(GenreDTO genreDto)
        {
            var genre = new Genres
            {
                Id = genreDto.Id,
                Genre = genreDto.Genre
            };
            await database.Genre.Create(genre);
            await database.Save();
        }

        public async Task UpdateGenre(GenreDTO genreDto)
        {
            var genre = new Genres
            {
                Id = genreDto.Id,
                Genre = genreDto.Genre
            };
            database.Genre.Update(genre);
            await database.Save();
        }   
   
       
        public async Task DeleteGenre(int id)
        {
            await database.Genre.Delete(id);
            await database.Save();
        }

        public async Task<GenreDTO> GetGenre(int id)
        {
            var genre = await database.Genre.Get(id);
            if (genre == null)
                throw new ValidationException("Дані відсутні!", nameof(id));

            return mapper.Map<GenreDTO>(genre);
        }

        public async Task<IEnumerable<GenreDTO>> GetAllGenres()
        {
            var genres = await database.Genre.GetAll();
            return mapper.Map<IEnumerable<GenreDTO>>(genres);
        }
    }
}
