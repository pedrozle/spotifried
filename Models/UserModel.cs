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
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Digite a senha")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    // Método para verificar senha
    public bool CheckPassword(string pass)
    {
        return Password == pass.GenerateHash(); 
    }

    // Método para definir o hash da senha
    public void SetPasswordHash()
    {
        Password = Password.GenerateHash(); 
    }
}
