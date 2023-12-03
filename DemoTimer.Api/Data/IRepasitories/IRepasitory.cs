using System.Linq.Expressions;

namespace DemoTimer.Api.Data.IRepasitories;

public interface IRepasitory<T> where T : class
{
    Task<T> CreateAsync(T entity);
    void Destroy(T entity);
    IQueryable<T> SelectAll();
    Task SaveAsync();
}
