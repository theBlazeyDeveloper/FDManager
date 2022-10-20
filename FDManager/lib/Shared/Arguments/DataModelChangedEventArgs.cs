namespace Shared.Arguments
{
    public sealed class DataModelChangedEventArgs<T> : EventArgs
    {
        public DataModelChangedEventArgs(T model)
        {
            Model = model;
        }

        public T Model { get; }

        public static implicit operator DataModelChangedEventArgs<T>(T model) => new(model);
    }
}
