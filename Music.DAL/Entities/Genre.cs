
using System.ComponentModel.DataAnnotations;

namespace MusicPortal.DAL.Entities
{
    public class Genres
    {
        public int Id { get; set; }
        public string? Genre { get; set; }
        public ICollection<Song> Songs { get; set; } = new List<Song>();

    }
}
