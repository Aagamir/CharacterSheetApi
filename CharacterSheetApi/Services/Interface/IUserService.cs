using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface IUsersService
    {
        void RegisterUser(RegisterUserDto dto);

        string GenerateLoginToken(LoginDto dto);
    }
}