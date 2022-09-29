using BingMaps.Requests;
using BingMapsRESTToolkit;

namespace BingMaps.Interfaces
{
    public interface IBingMapWebServices
    {
        Task<double[]> GetGeoCodedUriFromAddress(RequestLocation Location);

        BoundingBox GetCypressTxAreaBox();
    }
}