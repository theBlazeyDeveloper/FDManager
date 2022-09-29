using Shared.Abstract;
using System.Linq.Expressions;

namespace Shared.Interfaces
{
    public interface IRepository<T> where T : DataModelBase<T>
    {
        bool IsConnected { get; }

        IAsyncEnumerable<T> GetAsync(Expression<Func<bool, T>>? predicate);

        Task Save(T entity);

        Task<int> SaveMany(IEnumerable<T> entities);
    }
}
