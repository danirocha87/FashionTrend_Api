using System;
using Microsoft.EntityFrameworkCore;

public class SupplierRepository : BaseRepository<Supplier>, ISupplierRepository
{
    public SupplierRepository(AppDbContext context) : base(context)
    {

    }

    public async Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken)
    {

        return await Context.Suppliers.FirstOrDefaultAsync(
            x => x.Email.Equals(email), cancellationToken);
    }
}
