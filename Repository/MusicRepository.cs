using Spotifried.Data;
using Spotifried.Models;
using Spotifried.Repository.Interfaces;

namespace Spotifried.Repository;

public class MusicRepository(DatabaseContext db) : IMusicRepository
{

    private readonly DatabaseContext _db = db;

    List<MusicModel> IMusicRepository.GetAllMusic(){
        return _db.Music.ToList();
    }

    MusicModel IMusicRepository.AddMusic(MusicModel music)
    {
        _db.Music.Add(music);
        _db.SaveChanges();
        return music;
    }
}