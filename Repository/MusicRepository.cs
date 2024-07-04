using Spotifried.Data;
using Spotifried.Models;
using Spotifried.Repository.Interfaces;

namespace Spotifried.Repository;

public class MusicRepository(DatabaseContext db) : IMusicRepository
{

    private readonly DatabaseContext _db = db;

    public MusicModel? GetById(int id)
    {
        return _db.Musics.FirstOrDefault(m => m.Id == id);
    }

    public List<MusicModel> GetAllMusic()
    {
        return _db.Musics.ToList();
    }

    public MusicModel AddMusic(MusicModel music)
    {
        _db.Musics.Add(music);
        _db.SaveChanges();
        return music;
    }

    public bool DeleteMusic(int id)
    {

        MusicModel? musicModel = GetById(id) ?? throw new Exception("Música não encontrada");
        _db.Musics.Remove(musicModel);
        _db.SaveChanges();
        return true;

    }

}