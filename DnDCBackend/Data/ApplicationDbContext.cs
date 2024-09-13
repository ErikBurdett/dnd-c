using Microsoft.EntityFrameworkCore;
using DnDCBackend.Models;

namespace DnDCBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Spell> Spells { get; set; } = null!;
        public DbSet<InventoryItem> InventoryItems { get; set; } = null!;
        public DbSet<Proficiency> Proficiencies { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<SavingThrow> SavingThrows { get; set; } = null!;
        public DbSet<ClassFeature> ClassFeatures { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Characters
            modelBuilder.Entity<Character>().HasData(new Character
            {
                CharacterId = 1,
                Name = "Gandalf",
                Race = "Maia",
                Class = "Wizard",
                Level = 20,
                Strength = 18,
                Dexterity = 12,
                Constitution = 16,
                Intelligence = 20,
                Wisdom = 18,
                Charisma = 15
            });

            // Seed data for Spells
            modelBuilder.Entity<Spell>().HasData(new Spell
            {
                SpellId = 1,
                Name = "Fireball",
                Level = "3",
                School = "Evocation",
                CastingTime = "1 Action",
                Range = "150 feet",
                Components = "V, S, M",
                Duration = "Instantaneous",
                Description = "A bright streak flashes from your pointing finger to a point you choose within range and then blossoms with a low roar into an explosion of flame.",
                CharacterId = 1
            });

            // Seed data for InventoryItems
            modelBuilder.Entity<InventoryItem>().HasData(new InventoryItem
            {
                InventoryItemId = 1,
                Name = "Staff of Power",
                Description = "A powerful magical staff used by wizards.",
                Quantity = 1,
                CharacterId = 1
            });

            // Seed data for Proficiencies
            modelBuilder.Entity<Proficiency>().HasData(new Proficiency
            {
                ProficiencyId = 1,
                Name = "Arcana",
                CharacterId = 1
            });

            // Seed data for Skills
            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                SkillId = 1,
                Name = "Spellcasting",
                CharacterId = 1
            });

            // Seed data for SavingThrows
            modelBuilder.Entity<SavingThrow>().HasData(new SavingThrow
            {
                SavingThrowId = 1,
                Name = "Wisdom",
                CharacterId = 1
            });

            // Seed data for ClassFeatures (without the navigation property)
            modelBuilder.Entity<ClassFeature>().HasData(new ClassFeature
            {
                ClassFeatureId = 1,
                Name = "Spell Mastery",
                Description = "At 18th level, you have achieved such mastery over certain spells that you can cast them at will.",
                CharacterId = 1 // Foreign key to Character
            });
        }
    }
}
