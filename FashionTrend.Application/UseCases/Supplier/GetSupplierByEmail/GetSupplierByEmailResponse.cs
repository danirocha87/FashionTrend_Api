
public sealed record GetSupplierByEmailResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<Material> Materials { get; set; }
    public List<SewingMachine> SewingMachines { get; set; }
}
