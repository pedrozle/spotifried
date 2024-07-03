using System.ComponentModel.DataAnnotations;
using Spotifried.Helpers;

namespace Spotifried.Models;

public class UserModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Digite o nome")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Digite o username")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Digite o email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Digite a senha")]
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
    public string Username { get; set; }

    [Required(ErrorMessage = "Digite a senha")]
    public string Password { get; set; }
}