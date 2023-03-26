namespace CharacterSheetApi.Models.CharacterSheetDtos
{
    public class AddEquipmentDto
    {
        public List<int> EquipmentIds { get; set; }
        public int CharacterInfoId { get; set; }
    }
}
