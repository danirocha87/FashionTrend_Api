public sealed record CreateSupplierResponse
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<Material> Materials { get; set; }
    public List<SewingMachine> SewingMachines { get; set; }

}