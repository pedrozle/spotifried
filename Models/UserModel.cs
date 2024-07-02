using System.ComponentModel.DataAnnotations;
using Spotifried.Helpers;

namespace Spotifried.Models;

public class UserModel
{
    public UserModel() { }
    public UserModel(string name, string username, string email, string password)
    {
        Name = name;
        Username = username;
        Email = email;
        Password = password;
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool CheckPassword(string pass)
    {
        return Password == pass.GenerateHash();
    }

    public void SetPasswordHash()
    {
        Password = Password.GenerateHash();
    }

}

public class UserLoginModel
{
    [Required(ErrorMessage = "Digite o username")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Digite a senha")]
    public string? Password { get; set; }
}