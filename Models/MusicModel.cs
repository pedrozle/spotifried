using System.ComponentModel.DataAnnotations;

namespace Spotifried.Models;

public class MusicModel
{

    public MusicModel() { }

    // Constructor with parameters
    public MusicModel(string title, string artist, string album, string genre, int duration)
    {
        Title = title;
        Artist = artist;
        Album = album;
        Genre = genre;
        Duration = duration;
    }

    public int Id { get; set; }
    [Required(ErrorMessage = "Título obrigatório")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Artista obrigatório")]
    public string Artist { get; set; }
    [Required(ErrorMessage = "Album obrigatório")]
    public string Album { get; set; }
    [Required(ErrorMessage = "Gênero obrigatório")]
    public string Genre { get; set; }
    [Required(ErrorMessage = "Duração obrigatório")]
    public int Duration { get; set; }
    public int Rating { get; set; }

}