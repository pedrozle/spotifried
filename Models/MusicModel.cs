using System.ComponentModel.DataAnnotations;

namespace Spotifried.Models;

public class MusicModel
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Genre { get; set; }

    public int Duration { get; set; } // Duração em segundos

    public int AlbumId { get; set; }
    public AlbumModel Album { get; set; }

    // Lista de Avaliações
    public ICollection<Rating> Ratings { get; set; }
}