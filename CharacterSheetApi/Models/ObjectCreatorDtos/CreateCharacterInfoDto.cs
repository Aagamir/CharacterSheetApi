using CharacterSheetApi.Entities;

namespace CharacterSheetApi.Models
{
    public class CreateCharacterInfoDto
    {
        public string Name { get; set; }
        public int PlayerInfoId { get; set; } 
        public int ExpiriencePointsId { get; set; }
        public int CharacterDescriptionId { get; set; }
        public int ClassId { get; set; }
        public int? LastClassId { get; set; }
        public int BaseStatsId { get; set; }
        public int MonetaryWealthId { get; set; }

    }
}
