using Spotifried.Data;
using Spotifried.Models;
using Spotifried.Repository.Interfaces;

namespace Spotifried.Repository;

public class UserRepository(DatabaseContext db) : IUserRepository
{

    private readonly DatabaseContext _db = db;

    public UserModel? GetById(int id)
    {
        return _db.Users.FirstOrDefault(m => m.Id == id);
    }

    public List<UserModel> GetAllUser()
    {
        return _db.Users.ToList();
    }

    public UserModel AddUser(UserModel user)
    {
        _db.Users.Add(user);
        _db.SaveChanges();
        return user;
    }

    public bool DeleteUser(int id)
    {

        UserModel? UserModel = GetById(id) ?? throw new Exception("Música não encontrada");
        _db.Users.Remove(UserModel);
        _db.SaveChanges();
        return true;

    }

}