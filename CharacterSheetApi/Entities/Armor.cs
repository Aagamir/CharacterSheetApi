using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Entities
{
    public class Armor
    {
        public ArmorTypeId ArmorTypeId { get; set; }
        public ArmorType ArmorType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArmorPoints { get; set; }
        public int Weight { get; set; }
        public List<BodyLocations> BodyLocations { get; set; }

        public List<CharacterInfo> CharacterInfo { get; set; }
    }
}