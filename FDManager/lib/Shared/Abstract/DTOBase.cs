namespace Shared.Abstract
{
    public abstract class DTOBase
    {
        public DTOBase() { }        
    }

    public abstract class DTOBase<T> : DTOBase
    {
        public DTOBase() { }

        public abstract T? CSVDeserialize(string value);
    }
}
