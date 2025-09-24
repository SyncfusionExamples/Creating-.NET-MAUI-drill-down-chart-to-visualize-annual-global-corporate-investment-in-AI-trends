using System.Collections.ObjectModel;

namespace DrilldownMAUIChart
{
    public class YearlyInvestmentModel
    {
        public string Year { get; set; }
        public double Value { get; set; }

        public string FormattedValue => $"{Value / 1_000_000_000:F2} B";

        public YearlyInvestmentModel(string year, double value)
        {
            Year = year;
            Value = value;
        }
    }

    public class InvestmentModel
    {
        public string Type { get; set; }
        public double Value { get; set; }
        public ObservableCollection<YearlyInvestmentModel> YearlyBreakdown { get; set; }

        public string FormattedValue => $"{Value / 1_000_000_000:F2} B";

        public InvestmentModel(string type, double value, ObservableCollection<YearlyInvestmentModel> breakdown)
        {
            Type = type;
            Value = value;
            YearlyBreakdown = breakdown;
        }
    }
}
