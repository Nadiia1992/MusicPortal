using AutoMapper;
using MusicPortal.BLL.DTO;
using MusicPortal.DAL.Entities;

namespace MusicPortal.BLL.Profiles
{
    public class MusicProfile : Profile
    {
        public MusicProfile()
        {
            CreateMap<Users, UserDTO>();
            CreateMap<Singers, SingerDTO>();
            CreateMap<Genres, GenreDTO>();

            CreateMap<Song, SongDTO>()
            .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User != null ? src.User.LastName : null))
            .ForMember(dest => dest.Singer, opt => opt.MapFrom(src => src.Singer != null ? src.Singer.Singer : null))
            .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre != null ? src.Genre.Genre : null));
        }
    }
}