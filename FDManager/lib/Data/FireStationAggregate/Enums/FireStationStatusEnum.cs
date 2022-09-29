namespace Data.FireStationAggregate
{
    public enum FireStationStatusEnum
    {
        Active, Closed, TempClosed, Unknown
    }

    public static class FireStationStatusEnumExtensions
    {
        public static FireStationStatusEnum ToStatusEnum(this string value)
        {
            return value switch
            {
                "active" => FireStationStatusEnum.Active,
                "closed" => FireStationStatusEnum.Closed,
                "TempClosed" => FireStationStatusEnum.TempClosed,
                _ => FireStationStatusEnum.Unknown,
            };
        }
    }
}
