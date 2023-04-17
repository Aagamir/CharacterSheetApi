using CharacterSheetApi.Entities;
using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Models
{
    public class CreateSkillDto
    {
        public string Name { get; set; }
        public SkillLevelId SkillLevelId { get; set; }
    }
}
