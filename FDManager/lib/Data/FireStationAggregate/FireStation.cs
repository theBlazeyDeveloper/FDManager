using Shared.Abstract;

namespace Data.FireStationAggregate
{
    public class FireStation : DataModelBase<FireStation>
    {
        FireStation(FireStationDTO station) : base()
        {
            Number = station.Number;
            Status = station.Status.ToStatusEnum();
            Address = station.Address;
            CouncilDistrict = station.CouncilDistrict;
            District = station.District;
        }

        public FireStation(int number, FireStationStatusEnum status, string councilDistrict, string district) : base()
        {
            Number = number;
            Status = status;
            CouncilDistrict = councilDistrict;
            District = district;
        }

        public int Number { get; set; }
        public FireStationStatusEnum Status { get; set; }
        public string Address { get; set; } = string.Empty;
        public string CouncilDistrict { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;

        public static implicit operator FireStation(FireStationDTO station) => new(station);       
    }
}
