using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SkillLevelId SkillLevelId { get; set; }
        public SkillLevel SkillLevel { get; set; }

        public List<CharacterInfo> CharacterInfo { get; set; }
    }
}