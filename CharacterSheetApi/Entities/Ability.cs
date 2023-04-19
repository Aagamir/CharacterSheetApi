﻿namespace CharacterSheetApi.Entities
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<CharacterInfo> CharacterInfo { get; set; }
    }
}