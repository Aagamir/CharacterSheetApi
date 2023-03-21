namespace CharacterSheetApi.Entities
{
    public class CharacterInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public  PlayerInfo PlayerInfo { get; set; }
        public  ExpiriencePoints ExpiriencePoints { get; set; }
        public  CharacterDescription CharacterDescription { get; set; }
        public  CurrentClass CurrentClass { get; set; }
        public  Class Class { get; set; }
        public  LastClass LastClass { get; set; }
        public  BaseStats BaseStats { get; set; }
        public  GrowthStats GrowthStats { get; set; }
        public  CurrentStats CurrentStats { get; set; }
        public  List<Weapon> Weapons { get; set; }
        public  List<Armor> Armor { get; set; }
        public  List<Skill> Skills { get; set; }
        public  List<Ability> Abilities { get; set; }
        public  List<Equipment> Equipment { get; set; }
        public  MonetaryWealth MonetaryWealth { get; set; }
    }
}
