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

    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public int Rating { get; set; }

}