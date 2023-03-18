 using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface IUsersService
    {
        void UserPutterInDatabase(RegisterUserDto dto);
        string GenerateLoginToken(LoginDto dto);
    }
}