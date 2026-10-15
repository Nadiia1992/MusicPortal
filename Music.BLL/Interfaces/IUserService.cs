using MusicPortal.BLL.DTO;


namespace MusicPortal.BLL.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(UserDTO userDto);
        Task UpdateUser(UserDTO userDto);
        Task DeleteUser(int id);
        Task<UserDTO> GetUser(int id);
        Task<IEnumerable<UserDTO>> GetAllUsers();
    }
}
