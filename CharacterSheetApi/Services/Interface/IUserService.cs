using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface IUsersService
    {
        int RegisterUser(RegisterUserDto dto);

        string GenerateLoginToken(LoginDto dto);
    }
}