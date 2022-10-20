using Shared.Abstract;
using System.Text.Json.Serialization;

namespace Data.ItemAggregate
{
    public sealed class ItemDTO : DTOBase<ItemDTO>
    {
        public ItemDTO()
        {
        }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("locationId")]
        public string LocationId { get; set; } = string.Empty;

        [JsonPropertyName("itemTypeId")]
        public string ItemTypeId { get; set; } = string.Empty;

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("itemStatus")]
        public string ItemStatus { get; set; } = string.Empty;

        public override ItemDTO? CSVDeserialize(string value)
        {
            try
            {
                if (value.Length > 1)
                {
                    var splitValues = value.Split(',');

                    if (splitValues is not null)
                    {
                        Name = splitValues[0];
                        Description = splitValues[1];
                        ItemTypeId = splitValues[2];
                        LocationId = splitValues[3];
                        Quantity = int.TryParse(splitValues[4], out int qty) ? qty : 0;
                        ItemStatus = splitValues[5];

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
