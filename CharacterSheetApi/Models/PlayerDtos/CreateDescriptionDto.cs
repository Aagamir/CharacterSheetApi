using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Models
{
    public class CreateDescriptionDto
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CharacteriticSigns { get; set; }
        public GenderId GenderId { get; set; }
        public RaceId RaceId { get; set; }
    }
}
