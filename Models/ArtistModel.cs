using System.ComponentModel.DataAnnotations;

namespace Spotifried.Models;

public class ArtistModel
{

    public ArtistModel() { }

    public ArtistModel(string name)
    {
        Name = name;
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "Nome obrigatório")]
    public string Name { get; set; }

    public virtual List<AlbumModel> Albums { get; set; }

}