using Shared.Abstract;

namespace Data.ItemAggregate
{
    public sealed class Item : DataModelBase<Item>
    {
        public Item() : base()
        {
        }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string LocationId { get; set; } = string.Empty;

        public string ItemTypeId { get; set; } = string.Empty;

        public int Quantity { get; set; } = 0;
        
        public string ItemStatus { get; set; } = string.Empty;
    }
}
