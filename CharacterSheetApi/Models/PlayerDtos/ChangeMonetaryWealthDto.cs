namespace CharacterSheetApi.Models.playerDtos
{
    public class ChangeMonetaryWealthDto
    {
        public int MonetaryWealthId { get; set; }
        public int GoldCrowns { get; set; }
        public int SilverShilling { get; set; }
        public int CopperPences { get; set; }
    }
}