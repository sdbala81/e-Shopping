using eShopping.Orders.Domain;

using Microsoft.EntityFrameworkCore;

namespace eShopping.Orders.DataAccess;

/// <summary>
///     Source: My reference app https://github.com/dotnet-architecture/eShopOnWeb
///     Check it out if you need filtering/paging/etc.
///     Also consider Ardalis.Specification and its built-in generic repository
/// </summary>
public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
{
    private readonly OrderDbContext _orderDbContext;

    public EfRepository(OrderDbContext orderDbContext)
    {
        _orderDbContext = orderDbContext;
    }

    public virtual async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _orderDbContext.Set<T>()
            .FirstOrDefaultAsync(a => Equals(a.Id, id), cancellationToken);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken)
    {
        return await _orderDbContext.Set<T>()
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IReadOnlyList<T>> ListAllAsync(int perPage, int page, CancellationToken cancellationToken)
    {
        return await _orderDbContext.Set<T>()
            .Skip(perPage * (page - 1))
            .Take(perPage)
            .ToListAsync(cancellationToken);
    }

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
    {
        await _orderDbContext.Set<T>()
            .AddAsync(entity, cancellationToken);
        await _orderDbContext.SaveChangesAsync(cancellationToken);

        return entity;
    }

    public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        _orderDbContext.Entry(entity)
            .State = EntityState.Modified;
        await _orderDbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(T entity, CancellationToken cancellationToken)
    {
        _orderDbContext.Set<T>()
            .Remove(entity);
        await _orderDbContext.SaveChangesAsync(cancellationToken);
    }
}
