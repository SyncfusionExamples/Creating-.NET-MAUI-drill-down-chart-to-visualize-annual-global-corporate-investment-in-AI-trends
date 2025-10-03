using System.Collections.ObjectModel;

namespace DrilldownMAUIChart
{
    public class YearlyInvestmentModel
    {
        #region Properties

        public string Year { get; set; }
        public double Value { get; set; }
        public string FormattedValue => $"{Value / 1_000_000_000:F2} B"; 

        #endregion

        public YearlyInvestmentModel(string year, double value)
        {
            Year = year;
            Value = value;
        }
    }

    public class InvestmentModel
    {
        #region Properties

        public string Type { get; set; }
        public double Value { get; set; }
        public ObservableCollection<YearlyInvestmentModel> YearlyBreakdown { get; set; }
        public string FormattedValue => $"{Value / 1_000_000_000:F2} B"; 

        #endregion

        public InvestmentModel(string type, double value, ObservableCollection<YearlyInvestmentModel> breakdown)
        {
            Type = type;
            Value = value;
            YearlyBreakdown = breakdown;
        }
    }
}
