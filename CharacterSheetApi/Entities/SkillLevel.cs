using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Entities
{
    public class SkillLevel
    {
        public SkillLevelId SkillLevelId { get; set; }
        public string Name { get; set; }
        public List<Skill> Skill { get; set; }
    }
}
