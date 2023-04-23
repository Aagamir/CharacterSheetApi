using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetApi.Models.PlayerDtos
{
    public class GetAllWeaponsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int WeaponStrength { get; set; }
        public int Range { get; set; }
        public int ReloadTime { get; set; }
        public WeaponCategoryId WeaponCategoryId { get; set; }
        public string WeaponCategory { get; set; }
        public List<string> WeaponCharacteristics { get; set; }
    }
}