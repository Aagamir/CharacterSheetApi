using CharacterSheetApi.Entities;

namespace CharacterSheetApi.Models
{
    public class CreateCharacterInfoDto
    {
        public string Name { get; set; }
        public int PlayerInfoId { get; set; } 
        public int ExpiriencePointsId { get; set; }
        public int CharacterDescriptionId { get; set; }
        public int CurrentClassId { get; set; }
        public int LastClassId { get; set; }
        public int BaseStatsId { get; set; }
        public int MonetaryWealthId { get; set; }
        public List<int> WeaponIds { get; set; }
        public List<int> ArmorIds { get; set; }
        public List<int> SkillIds  { get; set; }
        public List<int> AbilityIds { get; set; }
        public List<int> EquipmentIds { get; set; }
    }
}
