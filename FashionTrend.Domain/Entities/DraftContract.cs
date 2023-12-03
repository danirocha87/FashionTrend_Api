public class DraftContract : BaseEntity
{
    public Guid SupplierId { get; set; }
    public Supplier Supplier { get; set; }
    public string Description { get; set; }
    public bool Accepted { get; set; }
}