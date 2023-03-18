using CharacterSheetApi.Models;

namespace CharacterSheetApi.Services
{
    public interface ICharacterSheetService
    {
        void AddWeapon (AddWeaponDto dto);
    }
}