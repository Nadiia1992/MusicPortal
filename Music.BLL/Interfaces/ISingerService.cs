using MusicPortal.BLL.DTO;


namespace MusicPortal.BLL.Interfaces
{
    public interface ISingerService
    {
        Task CreateSinger(SingerDTO singerDto);
        Task UpdateSinger(SingerDTO singerDto);
        Task DeleteSinger(int id);
        Task<SingerDTO> GetSinger(int id);
        Task<IEnumerable<SingerDTO>> GetAllSingers();
    }
}
