public interface IServiceOrderRepository : IBaseRepository<ServiceOrder>
{
    Task<List<ServiceOrder>> GetBySupplier(Guid SupplierId, CancellationToken cancellationToken);
}
