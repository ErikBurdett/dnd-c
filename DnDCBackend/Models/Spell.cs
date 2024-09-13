using System.ComponentModel.DataAnnotations;

namespace DnDCBackend.Models
{
    public class Spell
    {
        [Key]
        public int SpellId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // Initialized to avoid null

        public string Level { get; set; } = string.Empty; // Initialized to avoid null
        public string School { get; set; } = string.Empty; // Initialized to avoid null
        public string CastingTime { get; set; } = string.Empty; // Initialized to avoid null
        public string Range { get; set; } = string.Empty; // Initialized to avoid null
        public string Components { get; set; } = string.Empty; // Initialized to avoid null
        public string Duration { get; set; } = string.Empty; // Initialized to avoid null
        public string Description { get; set; } = string.Empty; // Initialized to avoid null

        // Foreign key to Character
        public int CharacterId { get; set; }

        // Nullable navigation property
        public Character? Character { get; set; }
    }
}
