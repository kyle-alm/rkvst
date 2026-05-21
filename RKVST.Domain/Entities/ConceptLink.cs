namespace RKVST.Domain.Entities
{
    public sealed class ConceptLink
    {
        public int ParentConceptId { get; init; }
        public int ChildConceptId { get; init; }
        public float Relevance { get; init; }
    }
}
