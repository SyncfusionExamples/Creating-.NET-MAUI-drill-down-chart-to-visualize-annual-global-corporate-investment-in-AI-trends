using Syncfusion.Maui.Toolkit.Charts;

namespace DrilldownMAUIChart;

public partial class YearlyInvestmentPage : ContentPage
{
    public YearlyInvestmentPage(InvestmentModel selectedData, Brush fill)
    {
        InitializeComponent();
        this.BindingContext = selectedData;
        series.Fill = fill;

        if (selectedData?.YearlyBreakdown != null && selectedData.YearlyBreakdown.Any())
        {
            double max = selectedData.YearlyBreakdown.Max(i => i.Value);
            double paddedMax = GetNiceMax(max);
            double interval = GetNiceInterval(paddedMax);

            yAxis.Minimum = 0;
            yAxis.Maximum = paddedMax;
            yAxis.Interval = interval;
        }
    }

    private static double GetNiceMax(double max)
    {
        double maxB = max / 1_000_000_000d;

        double[] candidates = new double[] { 40, 50, 60, 80, 100, 120, 150, 180, 200 };
        foreach (var c in candidates)
        {
            if (maxB <= c) return c * 1_000_000_000d;
        }
        double steps = Math.Ceiling(maxB / 50d) * 50d;
        return steps * 1_000_000_000d;
    }

    private static double GetNiceInterval(double max)
    {
        double maxB = max / 1_000_000_000d;
        if (maxB <= 40) return 5_000_000_000d;
        if (maxB <= 80) return 10_000_000_000d;
        if (maxB <= 120) return 20_000_000_000d;
        if (maxB <= 180) return 20_000_000_000d;
        return 25_000_000_000d;
    }
}
