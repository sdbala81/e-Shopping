using eShopping.Inventory.Domain;

using Microsoft.EntityFrameworkCore;

namespace eShopping.Inventory.DataAccess;

/// <summary>
///     Source: My reference app https://github.com/dotnet-architecture/eShopOnWeb
///     Check it out if you need filtering/paging/etc.
///     Also consider Ardalis.Specification and its built-in generic repository
/// </summary>
public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity<Guid>
{
    private readonly ProductDbContext _productDbContext;

    public EfRepository(ProductDbContext productDbContext)
    {
        _productDbContext = productDbContext;
    }

    public async Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken)
    {
        return await _productDbContext.Set<T>()
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IReadOnlyList<T>> ListAllAsync(int perPage, int page, CancellationToken cancellationToken)
    {
        return await _productDbContext.Set<T>()
            .Skip(perPage * (page - 1))
            .Take(perPage)
            .ToListAsync(cancellationToken);
    }

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
    {
        await _productDbContext.Set<T>()
            .AddAsync(entity, cancellationToken);
        await _productDbContext.SaveChangesAsync(cancellationToken);

        return entity;
    }

    public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        _productDbContext.Entry(entity)
            .State = EntityState.Modified;
        await _productDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(T entity, CancellationToken cancellationToken)
    {
        _productDbContext.Set<T>()
            .Remove(entity);
        await _productDbContext.SaveChangesAsync(cancellationToken);
    }

    public virtual async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _productDbContext.Set<T>()
            .FirstOrDefaultAsync(a => Equals(a.Id, id), cancellationToken);
    }
}
