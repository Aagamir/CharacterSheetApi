using CharacterSheetApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace CharacterSheetApi.Models
{
    public class RegisterUserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}