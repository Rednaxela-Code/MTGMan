namespace MTGManager.Shared.Models
{
    public class Collection
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Count { get; set; }
        public List<ScryfallCard>? Cards { get; set; }
    }
}
