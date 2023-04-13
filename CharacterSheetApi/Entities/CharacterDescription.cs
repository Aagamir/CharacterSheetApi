using CharacterSheetApi.Arrays;
using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Entities
{
    public class CharacterDescription
    {
        public int Id { get; set; }
        public RaceId RaceId { get; set; }
        public Race Race { get; set; }
        public GenderId GenderId { get; set; }
        public Gender Gender { get; set; }
        public EyeColorId EyeColorId { get; set; }
        public EyeColor EyeColor { get; set; }
        public HairColorId HairColorId { get; set; }
        public HairColor HairColor { get; set; }
        public StarSignId StarSignId { get; set; }
        public StarSign StarSign { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Siblings { get; set; }
        public int Age { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CharacteriticSigns { get; set; }
        public BaseStats BaseStats { get; set; }
        public GrowthStats? GrowthStats { get; set; }
        public CurrentStats CurrentStats { get; set; }
    }
}