using System.ComponentModel.DataAnnotations;

namespace Spotifried.Models;

public class MusicModel
{
    public MusicModel() { }

    // Constructor with parameters
    public MusicModel(string title, AlbumModel album, string genre, int duration)
    {
        Title = title;
        Album = album;
        Genre = genre;
        Duration = duration;
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "Título obrigatório")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Álbum obrigatório")]
    public AlbumModel Album { get; set; }

    public int AlbumId { get; set; }

    [Required(ErrorMessage = "Gênero obrigatório")]
    public string Genre { get; set; }

    [Required(ErrorMessage = "Duração obrigatório")]
    public int Duration { get; set; }

    public List<Rating> Ratings { get; set; } = [];

    public double GetRating()
    {
        return Ratings.Any() ? Ratings.Average(r => r.RatingValue) : 0;
    }

}