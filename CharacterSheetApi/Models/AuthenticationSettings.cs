﻿namespace CharacterSheetApi.Models
{
    public class AuthenticationSettings
    {
        public string JwtKey { get; set; }
        public string JwtIssuer { get; set; }
    }
}