using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Entities
{
    public class WeaponCharacteristics
    {
        public WeaponCharacteristicsId WeaponCharacteristicsId { get; set; }
        public string Name { get; set; }

        public List<Weapon> Weapons { get; set; }
    }
}
