public sealed class Service : BaseEntity
{
    public string Description { get; set; }
    public RequestType Type { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public List<SewingMachine> SewingMachines { get; set; }
    public int Quantity { get; set; }   
    public double UnitPrice { get; set; }
    public double TotalPrice => UnitPrice * Quantity;
    public bool Available { get; set; } = true;
    public int ServiceDays { get; set; }

}

