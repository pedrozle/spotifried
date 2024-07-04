using System.ComponentModel.DataAnnotations;

namespace Spotifried.Models;

public class AlbumModel
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public int ArtistId { get; set; }
    public ArtistModel Artist { get; set; }

    // Lista de gêneros
    public List<string> Genres { get; set; }

    public int Year { get; set; }

    public string UrlCover { get; set; }

    // Relacionamento 1:N com Musica
    public ICollection<MusicModel> Musics { get; set; }
}