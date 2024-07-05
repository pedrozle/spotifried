using System.ComponentModel.DataAnnotations;

namespace Spotifried.Models;

public class Rating
{
    public int Id { get; set; }

    [Required]
    [Range(1, 5)] // Assuming rating value is between 1 and 5
    public int Value { get; set; }
    
    public int MusicId { get; set; }
    public MusicModel Music { get; set; }

    public int UserId { get; set; }
    public UserModel User { get; set; }
}