using Shared.Abstract;
using System.Text.Json.Serialization;

namespace Data.ItemAggregate
{
    public sealed class ItemTypeDTO : DTOBase<ItemTypeDTO>
    {
        public ItemTypeDTO()
        {
        }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("colorId")]
        public string ColorId { get; set; } = string.Empty;

        [JsonPropertyName("hasExpiration")]
        public bool HasExpiration { get; set; }

        [JsonPropertyName("minimumQuantity")]
        public int MinimumQuantity { get; set; }

        [JsonPropertyName("maximumQuantity")]
        public int MaximumQuantity { get; set; }

        public override ItemTypeDTO? CSVDeserialize(string value)
        {
            try
            {
                if (value.Length > 1)
                {
                    var splitValues = value.Split(',');

                    if (splitValues is not null)
                    {
                        Name = splitValues[0];
                        ColorId = splitValues[1];
                        MaximumQuantity = int.TryParse(splitValues[2], out int min) ? min : 0;
                        MinimumQuantity = int.TryParse(splitValues[3], out int max) ? max : 0;
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
    }
}
