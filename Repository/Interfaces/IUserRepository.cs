using Spotifried.Models;

namespace Spotifried.Repository.Interfaces;

public interface IUserRepository{

    List<UserModel> GetAllUser();

    UserModel AddUser(UserModel user);

    UserModel? GetById(int id);

    UserModel? GetByUsername(string Username);

    bool DeleteUser(int id);

}