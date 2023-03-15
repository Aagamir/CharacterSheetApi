using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Entities
{
    public class BodyLocations
    {
        public BodyLocationsId BodyLocationsId { get; set; }
        public string Name { get; set; }

        public List<Armor> Armors { get; set; }
    }
}
