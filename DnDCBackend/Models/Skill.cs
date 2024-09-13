using System.ComponentModel.DataAnnotations;

namespace DnDCBackend.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // Initialized to avoid null

        // Foreign key to Character
        public int CharacterId { get; set; }

        // Nullable navigation property
        public Character? Character { get; set; }
    }
}
