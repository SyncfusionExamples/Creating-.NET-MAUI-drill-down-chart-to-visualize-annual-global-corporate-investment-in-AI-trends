using Syncfusion.Maui.Toolkit.Charts;
using System.Collections;

namespace DrilldownMAUIChart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
        }

        private void OnDoughnutSeriesSelectionChanging(object sender, ChartSelectionChangingEventArgs e)
        {
            var series = sender as DoughnutSeries;
            var items = series?.ItemsSource as IList;
            int selectedIndex = e.NewIndexes[0];
            var selectedData = items![selectedIndex] as InvestmentModel;
            Navigation.PushAsync(new YearlyInvestmentPage(selectedData!, series!.PaletteBrushes[selectedIndex]));
            e.Cancel = true;
        }
    }

    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 1;
        }
    }
}
