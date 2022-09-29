using Shared.Abstract;
using System.Text.Json.Serialization;

namespace Data.FireStationAggregate
{
    public class FireStationDTO : DTOBase<FireStationDTO>
    {
        public FireStationDTO() { }

        FireStationDTO(FireStation station) : base()
        {
            Number = station.Number;
            Status = station.Status.ToString();
            Address = station.Address;
            CouncilDistrict = station.CouncilDistrict;
            District = station.District;
        }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;

        [JsonPropertyName("councilDistrict")]
        public string CouncilDistrict { get; set; } = string.Empty;

        [JsonPropertyName("district")]
        public string District { get; set; } = string.Empty;

        [JsonPropertyName("apparatus")]
        public string[] Apparatus { get; set; } = Array.Empty<string>();

        public override FireStationDTO? CSVDeserialize(string value)
        {
            try
            {
                if (value.Length > 1)
                {
                    var splitValues = value.Split(',');

                    if (splitValues is not null)
                    {
                        Number = int.Parse(splitValues[0]);
                        Status = splitValues[3];
                        Address = $"{splitValues[1]}, {splitValues[2]}";
                        CouncilDistrict = splitValues[4];
                        District = splitValues[5];
                        Apparatus = splitValues[6].Split(",") ?? Array.Empty<string>();

                        return this;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public static explicit operator FireStationDTO(FireStation v) => new(v);        
    }
}
