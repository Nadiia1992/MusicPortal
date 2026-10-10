
namespace MusicPortal.DAL.Entities
{
    public class Singers
    {
        public int Id { get; set; }
        public string? Singer { get; set; }
        public string? Image { get; set; }

        public ICollection<Song> Songs { get; set; } = new List<Song>();

    }
}
