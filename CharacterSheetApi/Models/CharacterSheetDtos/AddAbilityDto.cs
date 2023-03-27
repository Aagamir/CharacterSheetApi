namespace CharacterSheetApi.Models.CharacterSheetDtos
{
    public class AddAbilityDto
    {
        public List<int> AbilityIds { get; set; }
        public int CharacterInfoId { get; set; }
    }
}
