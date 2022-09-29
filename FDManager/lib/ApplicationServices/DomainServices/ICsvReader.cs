using Shared.Abstract;

namespace ApplicationServices.DomainServices
{
    public interface ICsvReader
    {
        public Task<IEnumerable<T>> ReadAsync<T>(Stream inputStream) where T : DTOBase<T>, new();
    }
}
