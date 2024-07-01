using Spotifried.Models;

namespace Spotifried.Repository.Interfaces;

public interface IMusicRepository{

    MusicModel AddMusic(MusicModel music);

}