using DemoTimer.Api.Data.Contexts;
using DemoTimer.Api.Data.IRepasitories;
using Microsoft.EntityFrameworkCore;

namespace DemoTimer.Api.Data.Repasitories;

public class Repasitory<T> : IRepasitory<T> where T : class
{
    private readonly AppDbContext appDbContext;
    private readonly DbSet<T> dbSet;
    public Repasitory(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
        dbSet = this.appDbContext.Set<T>();
    }
    public async Task<T> CreateAsync(T entity)
    {
        await this.dbSet.AddAsync(entity);
        return entity;
    }

    public void Destroy(T entity)
    {
        this.dbSet.Remove(entity);
    }

    public async Task SaveAsync()
    {
        await appDbContext.SaveChangesAsync();
    }

    public IQueryable<T> SelectAll()
    {
        IQueryable<T> query = dbSet.AsQueryable();
        return query;
    }
}
