namespace CharacterSheetApi.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public virtual Role Role { get; set; }
        public virtual List<CharacterSheet> CharacterSheets { get; set; }
    }
}
