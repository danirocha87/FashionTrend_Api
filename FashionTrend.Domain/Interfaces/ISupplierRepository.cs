public interface ISupplierRepository : IBaseRepository<Supplier>
{
    Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken);
}