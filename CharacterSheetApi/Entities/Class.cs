﻿namespace CharacterSheetApi.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CharacterInfo> CharacterInfos { get; set; }
    }
}
