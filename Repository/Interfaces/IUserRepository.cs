using Spotifried.Models;

namespace Spotifried.Repository.Interfaces;

public interface IUserRepository{

    List<UserModel> GetAllUser();

    UserModel AddUser(UserModel user);

    UserModel? GetById(int id);

    bool DeleteUser(int id);

}