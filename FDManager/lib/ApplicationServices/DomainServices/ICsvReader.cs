using Shared.Abstract;

namespace Presentation.DomainServices
{
    public interface ICsvReader
    {
        public Task<IEnumerable<T>> ReadAsync<T>(Stream inputStream) where T : DTOBase<T>, new();
    }
}
