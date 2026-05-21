namespace RKVST.Domain.Entities
{
    public sealed class Entry
    {
        public long EntryId { get; set; }
        public long OriginId { get; set; }
        public int Version { get; init; }
        public bool IsCurrentVersion { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
