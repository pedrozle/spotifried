using System.ComponentModel.DataAnnotations;

namespace Spotifried.Models;

public class AlbumModel
{

    public AlbumModel() { }

    public AlbumModel(string title, DateTime publish, int artistId)
    {
        Title = title;
        PublishedAt = publish;
        ArtistId = artistId;
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "Título obrigatório")]
    public string Title { get; set; }

    public DateTime PublishedAt { get; set; }

    [Required(ErrorMessage = "Artista obrigatório")]
    public int ArtistId { get; set; }

    public ArtistModel Artist { get; set; }

    public virtual List<MusicModel> Musics { get; set; }

}