﻿using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Entities
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int WeaponStrength { get; set; }
        public int Range { get; set; }
        public int ReloadTime { get; set; }
        public WeaponCategoryId WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; }
        public List<WeaponCharacteristics> WeaponCharacteristics { get; set; }

        public List<CharacterInfo> CharacterInfo { get; set; }
    }
}