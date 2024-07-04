using System.ComponentModel.DataAnnotations;

namespace Spotifried.Models;

public class ArtistModel
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    // Relacionamento 1:N com Album
    public ICollection<AlbumModel> Albuns { get; set; }
}