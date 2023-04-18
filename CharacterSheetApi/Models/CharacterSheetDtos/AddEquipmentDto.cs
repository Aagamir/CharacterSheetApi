namespace CharacterSheetApi.Models.CharacterSheetDtos
{
    public class AddEquipmentDto
    {
        public List<int> EquipmentIds { get; set; }
        public int CharacterSheetId { get; set; }
    }
}