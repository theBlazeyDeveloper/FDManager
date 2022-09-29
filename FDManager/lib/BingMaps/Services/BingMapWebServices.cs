using BingMaps.Interfaces;
using BingMaps.Options;
using BingMaps.Requests;
using BingMapsRESTToolkit;
using Microsoft.Extensions.Options;

namespace BingMaps.Services
{
    internal class BingMapWebServices : IBingMapWebServices
    {
        const string _userRegion = "US";
        const string _culture = "en-US";
        const string _userIP = "127.0.0.1";
        const string _domain = "https://dev.virtualearth.net/REST/v1/";

        readonly static BoundingBox _cypressTxAreaBox = new()
        {
            EastLongitude = -95.522743,
            NorthLatitude = 30.050663,
            SouthLatitude = 29.789587,
            WestLongitude = -95.890009
        };

        readonly BingMapOptions _options;

        public BingMapWebServices(IOptions<BingMapOptions> opts)
        {
            _options = opts.Value;

            if(string.IsNullOrEmpty(_options.BingMapsApiKey))
                throw new (nameof(_options.BingMapsApiKey));
        }

        public BoundingBox GetCypressTxAreaBox() => _cypressTxAreaBox;

        public async Task<double[]> GetGeoCodedUriFromAddress(RequestLocation requestLocation)
        {
            try
            {
                double[] resultCoordinates = new double[2];

                var location = BuildLocation(requestLocation);

                location.QueryParseValues = new[] 
                {
                    new QueryParseValue() { Property = "AddressLine", Value = location.Address.AddressLine },
                    new QueryParseValue() { Property = "AdminDistrict", Value = location.Address.AdminDistrict },
                    new QueryParseValue() { Property = "AdminDistrict2", Value = location.Address.AdminDistrict2 },
                    new QueryParseValue() { Property = "PostalCode", Value = location.Address.PostalCode }
                };

                GeocodeRequest request = new()
                {
                    BingMapsKey = _options.BingMapsApiKey,
                    UserIp = _userIP,
                    IncludeIso2 = true,

                    Address = new SimpleAddress()
                    {
                        AddressLine = location.Address.AddressLine,
                        AdminDistrict = location.Address.AdminDistrict,
                        CountryRegion = location.Address.CountryRegion,
                        PostalCode = location.Address.PostalCode,
                        Locality = requestLocation.StateAbbreviation
                    },
                    Domain = _domain,
                    Culture = _culture,
                    UserRegion = _userRegion,
                    
                    UserMapView = _cypressTxAreaBox,
                    IncludeNeighborhood = true,
                    Query = requestLocation.QueryString
                };

                Response response = await ServiceManager.GetResponseAsync(request);

                if (response != null && response.ResourceSets != null && response.ResourceSets.Length > 0 && response.ResourceSets[0].Resources != null && response.ResourceSets[0].Resources.Length > 0)
                {
                    if (response.ResourceSets[0].Resources[0] is Location result)
                    {
                        if (result.Confidence == "High" || result.Confidence == "Medium")
                        {
                            Point resultLocation = result.Point;
                            resultCoordinates = result.Point.Coordinates;
                        }
                    }
                }
                return resultCoordinates;
            }
            catch (Exception)
            {
                return new double[2];
            }
        }       

        readonly static Func<RequestLocation, Location> BuildLocation = (request) 
            => new Location()
            {
                Address = new Address()
                {
                    AddressLine = $"{request.StreetNumber} {request.StreetName}",
                    AdminDistrict = request.CityName,
                    AdminDistrict2 = _userRegion,
                    FormattedAddress = request.QueryString,
                    CountryRegion = "United States",
                    CountryRegionIso2 = _userRegion,
                    PostalCode = request.ZipCode
                },
                EntityType = "Address",
                Type = "Point",
            };
    }
}