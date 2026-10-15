using AutoMapper;
using MusicPortal.DAL.Interfaces;
using MusicPortal.BLL.DTO;
using MusicPortal.BLL.Infrastructure;
using MusicPortal.BLL.Interfaces;
using MusicPortal.DAL.Entities;


namespace MusicPortal.BLL.Services;

public class UserService(IUnitOfWork database, IMapper mapper) : IUserService
{
    public async Task CreateUser(UserDTO userDto)
    {
        var user = new Users
        {
            Id = userDto.Id,
            FirstName = userDto.FirstName,
            LastName = userDto.LastName,
            Login = userDto.Login,
            Email = userDto.Email,
            Password = userDto.Password
        };
        await database.User.Create(user);
        await database.Save();
    }

    public async Task UpdateUser(UserDTO userDto)
    {
        var user = new Users
        {
            Id = userDto.Id,
            FirstName = userDto.FirstName,
            LastName = userDto.LastName,
            Login = userDto.Login,
            Email = userDto.Email,
            Password = userDto.Password
        };
        database.User.Update(user);
        await database.Save();
    }


    public async Task DeleteUser(int id)
    {
        await database.User.Delete(id);
        await database.Save();
    }

    public async Task<UserDTO> GetUser(int id)
    {
        var user = await database.User.Get(id);
        if (user == null)
            throw new ValidationException("Дані відсутні!", nameof(id));

        return mapper.Map<UserDTO>(user);
    }

    public async Task<IEnumerable<UserDTO>> GetUsers()
    {
        var users = await database.User.GetAll();
        return mapper.Map<IEnumerable<UserDTO>>(users);
    }

    Task<IEnumerable<UserDTO>> IUserService.GetAllUsers()
    {
        throw new NotImplementedException();
    }
}
