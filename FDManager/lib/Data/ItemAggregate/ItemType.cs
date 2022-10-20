using Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.ItemAggregate
{
    public sealed class ItemType : DataModelBase<ItemType>
    {
        public ItemType() : base()
        {
        }

        public string Name { get; set; } = string.Empty;

        public string ColorId { get; set; } = string.Empty;

        public bool HasExpiration { get; set; }

        public int MinimumQuantity { get; set; }

        public int MaximumQuantity { get; set; }
    }
}
