using Microsoft.EntityFrameworkCore;

public class ServiceRepository : BaseRepository<Service>, IServiceRepository
{
    public ServiceRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<List<Service>> GetByType(RequestType Type, CancellationToken cancellationToken)
    {
        return await Context.Services
            .Where(x => x.Type.Equals(Type) && x.Available == true)
            .ToListAsync(cancellationToken);
    }
}
