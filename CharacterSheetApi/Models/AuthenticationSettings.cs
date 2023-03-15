namespace CharacterSheetApi.Models
{
    public class AuthenticationSettings
    {
        public string JwtKey { get; set; }
        public int JwkExpireDays { get; set; }
        public string JwtIssuer { get; set; }
        public double JwtExpireDays { get; internal set; }
    }
}
