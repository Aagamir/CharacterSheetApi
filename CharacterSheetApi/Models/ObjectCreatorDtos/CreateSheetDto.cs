using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Models
{
    public class CreateSheetDto
    {
        public string Name { get; set; }
        public RpgSystemId RpgSystem { get; set; }
        public string CreatorName { get; set; }
    }
}
