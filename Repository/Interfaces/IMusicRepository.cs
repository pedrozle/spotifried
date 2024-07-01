using Spotifried.Models;

namespace Spotifried.Repository.Interfaces;

public interface IMusicRepository{

    List<MusicModel> GetAllMusic();

    MusicModel AddMusic(MusicModel music);

    MusicModel? GetById(int id);

    bool DeleteMusic(int id);

}