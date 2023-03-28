using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Models.ObjectCreatorDtos
{
    public class ChangeCharacterDescriptionDto
    {
        public int CharacterDescriptionId { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CharacteriticSigns { get; set; }
        public GenderId GenderId { get; set; }
        public RaceId RaceId { get; set; }
        public HairColorId HairColorId { get; set; }
        public StarSignId StarSignId { get; set; }
    }
}
