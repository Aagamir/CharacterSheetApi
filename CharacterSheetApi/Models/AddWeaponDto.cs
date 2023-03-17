namespace CharacterSheetApi.Models
{
    public class AddWeaponDto
    {
        public List<int> WeaponIds { get; set; }
        public int CharacterInfoId { get; set; }
    }
}
