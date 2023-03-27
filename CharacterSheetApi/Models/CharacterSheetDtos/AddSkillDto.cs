using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Models.CharacterSheetDtos
{
    public class AddSkillDto
    {
        public List<int> SkillIds { get; set; }
        public int CharacterInfoId { get; set; }
    }
}
