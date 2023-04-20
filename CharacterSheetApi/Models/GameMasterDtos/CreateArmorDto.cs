using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Services
{
    public class CreateArmorDto
    {
        public string Name { get; set; }
        public int ArmorPoints { get; set; }
        public int Weight { get; set; }
        public ArmorTypeId ArmorType { get; set; }
        public List<BodyLocationsId> BodyLocations { get; set; }
    }
}