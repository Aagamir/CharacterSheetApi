using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Entities
{
    public class CharacterSheet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RpgSystemId RpgSystemId { get; set; }
        public RpgSystem RpgSystem { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string CreatorName { get; set; }
        public int UsersId { get; set; }

        public virtual CharacterInfo CharacterInfo { get; set; }
    }
}