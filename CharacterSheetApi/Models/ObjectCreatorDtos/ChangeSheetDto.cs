using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Models.ObjectCreatorDtos
{
    public class ChangeSheetDto
    {
        public int CharacterSheetId { get; set; }

        public string Name { get; set; }
        public RpgSystemId RpgSystem { get; set; }
        public int CharacterInfoId { get; set; }
        public string CreatorName { get; set; }
    }
}
