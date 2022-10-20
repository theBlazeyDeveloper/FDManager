using Shared.Abstract;
using System.Text;

namespace Presentation.DomainServices
{
    internal sealed class CsvReader : ICsvReader
    {
        public CsvReader(){ }

        public async Task<IEnumerable<T>> ReadAsync<T>(Stream inputStream) where T : DTOBase<T>, new()
        {
            byte[] buffer = new byte[inputStream.Length];          

            await inputStream.ReadAsync(buffer.AsMemory(0, (int)inputStream.Length));

            var dataString = Encoding.UTF8.GetString(buffer);

            var splitString = dataString.Split("\r\n");

            var items = new List<T>();

            foreach(var split in splitString) 
            {
                var data = new T().CSVDeserialize(split);            

                if(data is not null)
                    items.Add(data);
            }

            return items ?? Enumerable.Empty<T>();
        }
    }
}
