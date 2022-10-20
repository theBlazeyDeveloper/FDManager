namespace Components.Charts
{
    public sealed class BarData
    {
        readonly IList<BarDataItem> _dataItems = new List<BarDataItem>();

        public BarData(string title, IEnumerable<BarDataItem> data, IList<string?> colors = default!)
        {
            _dataItems = data.ToList();
            Title = title;
            Colors = colors;
        }

        public string? Title { get; set; }
        public IList<string?> Colors { get; set; } = new List<string?>();
        public IEnumerable<BarDataItem> Data { get => _dataItems; }
    }

    public record BarDataItem
    {
        public string? Title { get; set; }
        public int Count { get; set; }
    }
}
