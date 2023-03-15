namespace CharacterSheetApi.Entities
{
    public class CharacterInfo
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual PlayerInfo? PlayerInfo { get; set; }
        public virtual ExpiriencePoints? ExpiriencePoints { get; set; }
        public virtual CharacterDescription? CharacterDescription { get; set; }
        public virtual CurrentClass? CurrentClass { get; set; }
        public virtual LastClass? LastClass { get; set; }
        public virtual BaseStats? BaseStats { get; set; }
        public virtual GrowthStats? GrowthStats { get; set; }
        public virtual CurrentStats? CurrentStats { get; set; }
        public virtual Weapon? Weapon { get; set; }
        public virtual Armor? Armor { get; set; }
        public virtual Skill? Skills { get; set; }
        public virtual Ability? Abilities { get; set; }
        public virtual Equipment? Equipment { get; set; }
        public virtual MonetaryWealth? MonetaryWealth { get; set; }
    }
}
