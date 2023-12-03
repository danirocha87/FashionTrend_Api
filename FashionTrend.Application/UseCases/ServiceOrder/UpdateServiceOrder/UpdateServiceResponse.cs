
public sealed record UpdateServiceOrderResponse
{   
    public Guid Id { get; set; }
    public Guid SupplierId { get; set; }
    public Guid ServiceId { get; set; }
    public DateTime EstimatedDate { get; set; }
    public RequestStatus Status { get; set; }
    public bool Payed { get; set; }
}
