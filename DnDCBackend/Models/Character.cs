using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDCBackend.Models
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // Initialized to avoid null

        public string Race { get; set; } = string.Empty; // Initialized to avoid null
        public string Class { get; set; } = string.Empty; // Initialized to avoid null
        public int Level { get; set; }

        // Ability scores
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        // Relationships (nullable to avoid issues in seeding)
        public List<Spell> Spells { get; set; } = new List<Spell>();
        public List<InventoryItem> Inventory { get; set; } = new List<InventoryItem>();
        public List<Proficiency> Proficiencies { get; set; } = new List<Proficiency>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<SavingThrow> SavingThrows { get; set; } = new List<SavingThrow>();
        public List<ClassFeature> ClassFeatures { get; set; } = new List<ClassFeature>();
    }
}
