using System.ComponentModel.DataAnnotations;

namespace DnDCBackend.Models
{
    public class InventoryItem
    {
        [Key]
        public int InventoryItemId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // Initialized to avoid null

        public string Description { get; set; } = string.Empty; // Initialized to avoid null
        public int Quantity { get; set; }

        // Foreign key to Character
        public int CharacterId { get; set; }

        // Nullable navigation property
        public Character? Character { get; set; }
    }
}
