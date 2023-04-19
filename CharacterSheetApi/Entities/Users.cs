using CharacterSheetApi.Enums;

namespace CharacterSheetApi.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public RoleId RoleId { get; set; } = RoleId.Player;

        public virtual List<CharacterSheet> CharacterSheets { get; set; }
    }
}