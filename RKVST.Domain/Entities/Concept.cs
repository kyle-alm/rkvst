namespace RKVST.Domain.Entities
{
    public sealed class Concept
    {
        public int ConceptId { get; set; }
        public string Name { get; init; } = null!;
        public string Summary { get; init; } = null!;
        public DateTime CreatedAt { get; init; }
    }
}
