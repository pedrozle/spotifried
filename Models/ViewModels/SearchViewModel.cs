namespace Spotifried.Models.ViewModels;


public class RootModelArtist
{
    public dynamic? artists { get; set; }
}

public class RootModelAlbum
{
    public dynamic? albums { get; set; }
}

public class RootModelMusic
{
    public dynamic? tracks { get; set; }
}

public class RootModelAll
{
    public dynamic? tracks { get; set; }

    public dynamic? albums { get; set; }

    public dynamic? artists { get; set; }
}

public class MusicViewModel
{
    public List<MusicItem>? items { get; set; }
}

public class AlbumViewModel
{
    public List<AlbumItem>? items { get; set; }
}

public class ArtistViewModel
{
    public List<ArtistItem>? items { get; set; }

}

public class MusicItem
{
    public AlbumItem? album { get; set; }

    public int? id { get; set; }

    public string? name { get; set; }

    public string? preview_url { get; set; }
    public string? type { get; set; }
}

public class AlbumItem
{
    public string? album_type { get; set; }

    public int? total_tracks { get; set; }

    public int? id { get; set; }

    public List<Image>? images { get; set; }

    public string? name { get; set; }

    public string? release_date { get; set; }

    public List<ArtistItem>? artists { get; set; }

    public string? type { get; set; }

}

public class ArtistItem
{
    public List<string>? genres { get; set; }
    public string? id { get; set; }
    public List<Image>? images { get; set; }
    public string? name { get; set; }
    public string? type { get; set; }

}

public class Image
{
    public string? url { get; set; }
}