using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Models
{
    public class CreateSheetDto
    {
        public string Name { get; set; }
        public RpgSystemId RpgSystemId { get; set; }
        public int CharacterInfoId { get; set; }
        public string CreatorName { get; set; }
    }
}