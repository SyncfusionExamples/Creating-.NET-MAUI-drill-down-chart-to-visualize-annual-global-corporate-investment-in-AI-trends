using Syncfusion.Maui.Toolkit.Charts;

namespace DrilldownMAUIChart;

public partial class SecondaryPage : ContentPage
{
    public SecondaryPage(InvestmentModel selectedData, Brush fill)
    {
        InitializeComponent();
        this.chart.Title = $"Year-wise Investment for {selectedData.Type}";
        this.BindingContext = selectedData;
        series.Fill = fill;
    }
}