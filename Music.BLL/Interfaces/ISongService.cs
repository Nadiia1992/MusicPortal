using MusicPortal.BLL.DTO;


namespace MusicPortal.BLL.Interfaces
{
    public interface ISongService
    {
        Task CreateSong(SongDTO songDto);
        Task UpdateSong(SongDTO songDto);
        Task DeleteSong(int id);
        Task<SongDTO> GetSong(int id);
        Task<IEnumerable<SongDTO>> GetAllSongs();
    }
}
