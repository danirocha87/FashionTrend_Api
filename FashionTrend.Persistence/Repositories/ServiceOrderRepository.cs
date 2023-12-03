using Microsoft.EntityFrameworkCore;

public class ServiceOrderRepository : BaseRepository<ServiceOrder>, IServiceOrderRepository
{
    public ServiceOrderRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<List<ServiceOrder>> GetBySupplier(Guid SupplierId, CancellationToken cancellationToken)
    {
        return await Context.ServiceOrders
            .Where(x => x.SupplierId.Equals(SupplierId) && x.Status != RequestStatus.Rejected)
            .ToListAsync(cancellationToken);
    }
}
