using System.ComponentModel.DataAnnotations;

namespace DnDCBackend.Models
{
    public class ClassFeature
    {
        [Key]
        public int ClassFeatureId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // Initialized to avoid null

        public string Description { get; set; } = string.Empty; // Initialized to avoid null

        // Foreign key to Character
        public int CharacterId { get; set; }

        // Nullable navigation property to avoid issues in seeding
        public Character? Character { get; set; }
    }
}
