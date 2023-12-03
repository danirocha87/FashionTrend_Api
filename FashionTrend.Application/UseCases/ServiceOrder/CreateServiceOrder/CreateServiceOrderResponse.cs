public sealed record CreateServiceOrderResponse
{
    public Guid SupplierId { get; set; }
    public Guid ServiceId { get; set; }
    public DateTime EstimatedDate { get; set; }
    public RequestStatus Status { get; set; }
    public bool Payed { get; set; }
}