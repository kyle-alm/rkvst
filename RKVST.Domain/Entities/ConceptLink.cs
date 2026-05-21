namespace RKVST.Domain.Entities
{
    public sealed class ConceptLink
    {
        public int ParentId { get; init; }
        public int ChildId { get; init; }
        public float Relevance { get; init; }
    }
}
