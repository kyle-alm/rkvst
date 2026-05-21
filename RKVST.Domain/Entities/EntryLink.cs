namespace RKVST.Domain.Entities
{
    public sealed class EntryLink
    {
        public long EntryId { get; set; }
        public int ConceptId { get; set; }
        public float Relevance { get; init; }
    }
}
