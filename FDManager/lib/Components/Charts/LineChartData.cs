namespace Components.Charts
{
    public class LineChartData
    {
        readonly IList<LineChartDataItem> _dataItems = new List<LineChartDataItem>();

        public LineChartData(int year, string title, IEnumerable<LineChartDataItem> dataItems)
        {
            Year = year;
            Title = title;
            _dataItems = dataItems.ToList();
        }

        public int Year { get; }

        public string? Title { get; }

        public IEnumerable<LineChartDataItem> DataItems { get => _dataItems; }
    }

    public record LineChartDataItem
    {
        public LineChartDataItem()
        { }

        public string Month { get; init; } = string.Empty;
        public int Year { get; init; }
        public int Count { get; init; }
    }
}
