using MongoDB.Bson.Serialization.Attributes;
using Shared.Arguments;

namespace Shared.Abstract
{
    public delegate void DataModelEventHandler<T>(DataModelChangedEventArgs<T> args);

    public abstract class DataModelBase<T>
    {
        public DataModelBase()
        {
            Id = Guid.NewGuid().ToString(); 
            IsDeleted = false;

            OnCreated();
        }

        public string Id { get; }

        public DateTime Created { get; private set; }

        public DateTime Modified { get; private set; }

        public bool IsDeleted { get; private set; }

        [BsonIgnore]
        public DataModelEventHandler<DataModelBase<T>>? OnModelChanged;

        [BsonIgnore]
        public DataModelEventHandler<DataModelBase<T>>? OnModelDeleted;

        public void OnCreated()
        {
            Created = DateTime.Now;
            Modified = DateTime.Now;

            OnModelChanged?.Invoke(new(this));
        }

        public void OnUpdated()
        {
            Modified = DateTime.Now;

            OnModelChanged?.Invoke(new(this));
        }

        public void OnDeleted()
        {
            IsDeleted = true;
            Modified = DateTime.Now;

            OnModelDeleted?.Invoke(new(this));
        }
    }
}
