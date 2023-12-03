
public sealed record GetServiceByIdResponse
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public RequestType Type { get; set; }
    public Product Product { get; set; }
    public List<SewingMachine> SewingMachines { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public double TotalPrice { get; set; }
    public bool Available { get; set; }
    public int ServiceDays { get; set; }
}
