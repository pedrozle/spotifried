using Spotifried.Models;

namespace Spotifried.Helpers.Interfaces;

public interface ISessao{
    

    UserModel? GetSession();

    void SetSession(UserModel user);

    void DeleteSession();

}