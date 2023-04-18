namespace CharacterSheetApi.Models.CharacterSheetDtos
{
    public class AddArmorDto
    {
        public List<int> ArmorIds { get; set; }
        public int CharacterSheetId { get; set; }
    }
}