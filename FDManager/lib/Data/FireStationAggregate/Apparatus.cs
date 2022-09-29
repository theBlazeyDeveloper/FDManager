using Shared.Abstract;

namespace Data.FireStationAggregate
{
    public class Apparatus : DataModelBase<Apparatus>
    {
        public Apparatus(string stationId, ApparatusType apparatusType)
        {
            StationId = stationId;
            ApparatusType = apparatusType;
        }

        public string StationId { get; set; } = string.Empty;

        public ApparatusType ApparatusType { get; set; }
    }
}
