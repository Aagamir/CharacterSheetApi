using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Models
{
    public class CreateWeaponDto
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int WeaponStrenght { get; set; }
        public int Range { get; set; }
        public int ReloadTime { get; set; }
        public WeaponCategoryId WeaponCategory { get; set; }
        public List<WeaponCharacteristicsId> WeaponCharacteristics { get; set; }
    }
}
