
namespace MusicPortal.DAL.Entities
{
    public class Song
    {
        public int Id { get; set; }

        public string? NameOfSong { get; set; }

        public string? Foto { get; set; }
        public string? AudioPath { get; set; }

        public int UserId { get; set; }
        public Users? User { get; set; }

        public int SingersId { get; set; }

        public Singers? Singer { get; set; }

        public int GenreId { get; set; }
        public Genres? Genre { get; set; }
    }
}
