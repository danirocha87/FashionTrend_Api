using System.Collections.Generic;

public sealed class ServiceOrder : BaseEntity
{
    public Supplier Supplier { get; set; }
    public Guid SupplierId { get; set; }
    public Service Service { get; set; }
    public Guid ServiceId { get; set; }
    public DateTime EstimatedDate { get; set; } 
    public RequestStatus Status { get; set; } = RequestStatus.Pending;
    public bool Payed { get; set; } = false;

}
