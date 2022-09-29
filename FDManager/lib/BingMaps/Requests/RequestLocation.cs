namespace BingMaps.Requests
{
    public class RequestLocation
    {
        public RequestLocation(string streetNumber, string streetName, string stateAbbreviation, string cityName, string zipCode)
        {
            StreetNumber = streetNumber;
            StreetName = streetName;
            StateAbbreviation = stateAbbreviation;
            CityName = cityName;
            ZipCode = zipCode;

            QueryString = $"{streetNumber} {streetName}, {cityName}, {stateAbbreviation} {zipCode}";
        }

        public string StreetNumber { get; }
        public string StreetName { get; }
        public string StateAbbreviation { get; }
        public string CityName { get; }
        public string ZipCode { get; }
        public string QueryString { get; }
    }
}