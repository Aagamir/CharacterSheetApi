using CharacterSheetApi.Models;
using CharacterSheetApi.Models.ObjectCreatorDtos;

namespace CharacterSheetApi.Services
{
    public interface IObjectCreatorService
    {
        int CreateSheet(CreateSheetDto dto);
        void ChangeSheet(ChangeSheetDto dto);
        int CreateCharacterDescription(CreateDescriptionDto dto);
        void ChangeCharacterDescription(ChangeCharacterDescriptionDto dto);
        int CreateBaseStats(int characterDescriptionId);
        void ChangeBaseStats(ChangeStatsDto dto);
        int CreateMonetaryWealth(CreateMonetaryWealthDto dto);
        void ChangeMonetaryWealth(ChangeMonetaryWealthDto dto);
        int CreateExpiriencePoints(CreateExpiriencePointsDto dto);
        void ChangeExpiriencePoints(ChangeExpiriencePointsDto dto);
        int CreatePlayerInfo(CreatePlayerInfoDto dto);
        void ChangePlayerInfo(ChangePlayerInfoDto dto);
        int CreateCharacterInfo(CreateCharacterInfoDto dto);
        
    }
}
