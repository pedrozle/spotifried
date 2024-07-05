namespace Spotifried.Models.ViewModels;

public class RootModel {
    public dynamic artists { get; set; }
}

public class ArtistSearchViewModel
{
    public List<ArtistItem> items { get; set; }

}
public class ArtistItem
{
    public List<string> genres { get; set; }
    public string id { get; set; }
    public List<Image> images { get; set; }
    public string name { get; set; }
    
}

public class Image
{
    public string url { get; set; }
}
