namespace Spotifried.Models;

class MusicModel(string title, string artist, string album, string genre, int duration)
{

    public int Id { get; set; }

    public string Title { get; set; } = title;

    public string Artist { get; set; } = artist;

    public string Album { get; set; } = album;

    public string Genre { get; set; } = genre;

    public int Duration { get; set; } = duration;

    public int Rating { get; set; }

}