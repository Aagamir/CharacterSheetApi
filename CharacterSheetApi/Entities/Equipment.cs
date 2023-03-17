namespace CharacterSheetApi.Entities
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Weight { get; set; }
        public string? Description { get; set; }
        public List<CharacterInfo> CharacterInfo { get; set; }
    }
}
