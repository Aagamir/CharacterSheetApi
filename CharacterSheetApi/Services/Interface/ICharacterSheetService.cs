using CharacterSheetApi.Models;
using CharacterSheetApi.Models.CharacterSheetDtos;

namespace CharacterSheetApi.Services
{
    public interface ICharacterSheetService
    {
        void AddWeapon (AddWeaponDto dto);
        void AddArmor(AddArmorDto dto);
        void AddEquipment(AddEquipmentDto dto);
    }
}