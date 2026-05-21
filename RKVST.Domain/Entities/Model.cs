namespace RKVST.Domain.Entities
{
    public sealed class Model
    {
        public int ModelId { get; init; }
        public string Name { get; init; } = null!;
        public string DisplayName { get; init; } = null!;
        public string Provider { get; init; } = null!;
        public bool IsActive { get; init; }
    }
}
