using CharacterSheetApi.Enums;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetApi.Entities
{
    public class Context : DbContext
    {
        private string _connectionString =
            "Server=(localdb)\\mssqllocaldb;Database=SheetDb;Trusted_Connection=True";
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<BaseStats> BaseStats { get; set; }
        public DbSet<CharacterDescription> CharacterDescriptions { get; set; }
        public DbSet<CharacterInfo> CharacterInfos { get; set; }
        public DbSet<CharacterSheet> CharacterSheets { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<CurrentStats> CurrentStats { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<ExpiriencePoints> ExpiriencePoints { get; set; }
        public DbSet<GrowthStats> GrowthStats { get; set; }
        public DbSet<LastClass> LastClass { get; set; }
        public DbSet<MonetaryWealth> MonetaryWealth { get; set; }
        public DbSet<PlayerInfo> PlayerInfo { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<WeaponCharacteristics> WeaponsCharacteristics { get; set; }
        public DbSet<BodyLocations> BodyLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Users>()
                .Property(u => u.Name)
                .IsRequired();

            modelBuilder.Entity<Role>()
               .Property(u => u.Name)
               .IsRequired();

            modelBuilder
                .Entity<WeaponCharacteristics>()
                .Property(e => e.WeaponCharacteristicsId)
                .HasConversion<int>();

            modelBuilder
                .Entity<WeaponCharacteristics>().HasData(
                Enum.GetValues(typeof(WeaponCharacteristicsId))
                    .Cast<WeaponCharacteristicsId>()
                    .Select(e => new WeaponCharacteristics()
                    {
                        WeaponCharacteristicsId = e,
                        Name = e.ToString()
                    })
                );


            modelBuilder
                .Entity<Weapon>()
                .Property(e => e.WeaponCategoryId)
                .HasConversion<int>();
            modelBuilder
                .Entity<WeaponCategory>()
                .Property(e => e.WeaponCategoryId)
                .HasConversion<int>();
            modelBuilder
                .Entity<WeaponCategory>().HasData(
                Enum.GetValues(typeof(WeaponCategoryId))
                    .Cast<WeaponCategoryId>()
                    .Select(e => new WeaponCategory()
                    {
                        WeaponCategoryId = e,
                        Name = e.ToString()
                    })
                );


            modelBuilder
                .Entity<CharacterDescription>()
                .Property(e => e.StarSignId)
                .HasConversion<int>();
            modelBuilder
                .Entity<StarSign>()
                .Property(e => e.StarSignId)
                .HasConversion<int>();
            modelBuilder
                .Entity<StarSign>().HasData(
                Enum.GetValues(typeof(StarSignId))
                    .Cast<StarSignId>()
                    .Select(e => new StarSign()
                    {
                        StarSignId = e,
                        Name = e.ToString()
                    })
                );


            modelBuilder
                .Entity<Skill>()
                .Property(e => e.SkillLevelId)
                .HasConversion<int>();
            modelBuilder
                .Entity<SkillLevel>()
                .Property(e => e.SkillLevelId)
                .HasConversion<int>();
            modelBuilder
                .Entity<SkillLevel>().HasData(
                Enum.GetValues(typeof(SkillLevelId))
                    .Cast<SkillLevelId>()
                    .Select(e => new SkillLevel()
                    {
                        SkillLevelId = e,
                        Name = e.ToString()
                    })
                );



            modelBuilder
                .Entity<CharacterSheet>()
                .Property(e => e.RpgSystemId)
                .HasConversion<int>();
            modelBuilder
                .Entity<RpgSystem>()
                .Property(e => e.RpgSystemId)
                .HasConversion<int>();
            modelBuilder
                .Entity<RpgSystem>().HasData(
                Enum.GetValues(typeof(RpgSystemId))
                    .Cast<RpgSystemId>()
                    .Select(e => new RpgSystem()
                    {
                        RpgSystemId = e,
                        Name = e.ToString()
                    })
                );


            modelBuilder
                .Entity<CharacterDescription>()
                .Property(e => e.HairColorId)
                .HasConversion<int>();
            modelBuilder
                .Entity<HairColor>()
                .Property(e => e.HairColorId)
                .HasConversion<int>();
            modelBuilder
                .Entity<HairColor>().HasData(
                Enum.GetValues(typeof(HairColorId))
                    .Cast<HairColorId>()
                    .Select(e => new HairColor()
                    {
                        HairColorId = e,
                        Name = e.ToString()
                    })
                );

            modelBuilder
                .Entity<CharacterDescription>()
                .Property(e => e.RaceId)
                .HasConversion<int>();
            modelBuilder
                .Entity<Race>()
                .Property(e => e.RaceId)
                .HasConversion<int>();
            modelBuilder
                .Entity<Race>().HasData(
                Enum.GetValues(typeof(RaceId))
                    .Cast<RaceId>()
                    .Select(e => new Race()
                    {
                        RaceId = e,
                        Name = e.ToString()
                    })
                );


            modelBuilder
                .Entity<CharacterDescription>()
                .Property(e => e.GenderId)
                .HasConversion<int>();
            modelBuilder
                .Entity<Gender>()
                .Property(e => e.GenderId)
                .HasConversion<int>();
            modelBuilder
                .Entity<Gender>().HasData(
                Enum.GetValues(typeof(GenderId))
                    .Cast<GenderId>()
                    .Select(e => new Gender()
                    {
                        GenderId = e,
                        Name = e.ToString()
                    })
                );


            modelBuilder
                .Entity<CharacterDescription>()
                .Property(e => e.EyeColorId)
                .HasConversion<int>();
            modelBuilder
                .Entity<EyeColor>()
                .Property(e => e.EyeColorId)
                .HasConversion<int>();
            modelBuilder
                .Entity<EyeColor>().HasData(
                Enum.GetValues(typeof(EyeColorId))
                    .Cast<EyeColorId>()
                    .Select(e => new EyeColor()
                    {
                        EyeColorId = e,
                        Name = e.ToString()
                    })
                );

            modelBuilder
                .Entity<BodyLocations/*Armor*/>()
                .Property(e => e.BodyLocationsId)
                .HasConversion<int>();
           // /*
            modelBuilder
                .Entity<BodyLocations>()
                .Property(e => e.BodyLocationsId)
                .HasConversion<int>();
           // */
            modelBuilder
                .Entity<BodyLocations>().HasData(
                Enum.GetValues(typeof(BodyLocationsId))
                    .Cast<BodyLocationsId>()
                    .Select(e => new BodyLocations()
                    {
                        BodyLocationsId = e,
                        Name = e.ToString()
                    })
                );


            modelBuilder
                .Entity<Armor>()
                .Property(e => e.ArmorTypeId)
                .HasConversion<int>();
            modelBuilder
                .Entity<ArmorType>()
                .Property(e => e.ArmorTypeId)
                .HasConversion<int>();
            modelBuilder
                .Entity<ArmorType>().HasData(
                Enum.GetValues(typeof(ArmorTypeId))
                    .Cast<ArmorTypeId>()
                    .Select(e => new ArmorType()
                    {
                        ArmorTypeId = e,
                        Name = e.ToString()
                    })
                );

            modelBuilder
                .Entity<Role>()
                .Property(e => e.RoleId)
                .HasConversion<int>();
            modelBuilder
                .Entity<Role>()
                .Property(e => e.RoleId)
                .HasConversion<int>();
            modelBuilder
                .Entity<Role>().HasData(
                Enum.GetValues(typeof(RoleId))
                    .Cast<RoleId>()
                    .Select(e => new Role()
                    {
                        RoleId = e,
                        Name = e.ToString()
                    })
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }

}


