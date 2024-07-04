using System.ComponentModel.DataAnnotations;
namespace Spotifried.Models.ViewModels;

public class UserLoginModel
{
    [Required(ErrorMessage = "Digite o username")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Digite a senha")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}