namespace Data.ItemAggregate
{
    public enum ItemStatusEnum
    {
        Available = 0,
        Unavailable = 1,
        Unknown = 2
    }

    public static class ItemStatusEnumExtensions
    {
        public static ItemStatusEnum ToStatusEnum(this int value)
        {
            return value switch
            {
                0 => ItemStatusEnum.Available,
                1 => ItemStatusEnum.Unavailable,
                _ => ItemStatusEnum.Unknown                
            };
        }
    }
}
