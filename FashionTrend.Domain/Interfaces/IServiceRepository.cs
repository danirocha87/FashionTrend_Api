public interface IServiceRepository : IBaseRepository<Service>
{
    Task<List<Service>> GetByType(RequestType Type, CancellationToken cancellationToken);
}
