namespace CharacterSheetApi.Models
{
    public class CreatePlayerInfoDto
    {
        public string PlayerName { get; set; }
        public string? GameMasterName { get; set; }
        public string? CampaignName { get; set; }
        public string? CampaignDateTime { get; set; }
    }
}
