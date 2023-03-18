using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface IObjectCreatorService
    {
        int CreateSheet(CreateSheetDto dto);
        int CreateCharacterDescription(CreateDescriptionDto characterDescriptionDto);
        int CreateBaseStats(int characterDescriptionId);
        int CreateMonetaryWealth(CreateMonetaryWealthDto dto);
        int CreateExpiriencePoints(CreateExpiriencePointsDto dto);
        int CreatePlayerInfo(CreatePlayerInfoDto dto);
        int CreateCharacterInfo(CreateCharacterInfoDto dto);
    }
}
