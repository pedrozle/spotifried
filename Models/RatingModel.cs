namespace Spotifried.Models;

public class Rating
{
    public int Id { get; set; }

    public int RatingValue { get; set; }

    public int MusicModelId { get; set; }
    public MusicModel MusicModel { get; set; }
}