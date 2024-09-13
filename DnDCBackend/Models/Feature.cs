namespace DnDCBackend.Models
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string? Name { get; set; } // Nullable if this field can be null
        public string? Description { get; set; } // Nullable if this field can be null
    }
}
