using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrilldownMAUIChart.ViewModel
{
    public class InvestmentViewModel
    {
        public ObservableCollection<InvestmentModel> DoughnutData { get; set; }
        private ObservableCollection<YearlyInvestmentModel> MergerAcquisitionData { get; set; }
        private ObservableCollection<YearlyInvestmentModel> PrivateInvestmentData { get; set; }
        private ObservableCollection<YearlyInvestmentModel> PublicOfferingData { get; set; }
        private ObservableCollection<YearlyInvestmentModel> MinorityStakeData { get; set; }

        public List<Brush> CustomBrushes { get; set; }

        public InvestmentViewModel()
        {
            MergerAcquisitionData = new ObservableCollection<YearlyInvestmentModel>
            {
                new YearlyInvestmentModel("2013", 6886002147),
                new YearlyInvestmentModel("2014", 7657430075),
                new YearlyInvestmentModel("2015", 10117774371),
                new YearlyInvestmentModel("2016", 14733563855),
                new YearlyInvestmentModel("2017", 27282717703),
                new YearlyInvestmentModel("2018", 23621537646),
                new YearlyInvestmentModel("2019", 38612035790),
                new YearlyInvestmentModel("2020", 41701221954),
                new YearlyInvestmentModel("2021", 175360000000),
                new YearlyInvestmentModel("2022", 112395307052),
                new YearlyInvestmentModel("2023", 73153417451),
                new YearlyInvestmentModel("2024", 79635322826),
            };

            PrivateInvestmentData = new ObservableCollection<YearlyInvestmentModel>
            {
                new YearlyInvestmentModel("2013", 6013620118),
                new YearlyInvestmentModel("2014", 10942456130),
                new YearlyInvestmentModel("2015", 15262405407),
                new YearlyInvestmentModel("2016", 19339919451),
                new YearlyInvestmentModel("2017", 28432394624),
                new YearlyInvestmentModel("2018", 46509286091),
                new YearlyInvestmentModel("2019", 61664788424),
                new YearlyInvestmentModel("2020", 77256670048),
                new YearlyInvestmentModel("2021", 145400000000),
                new YearlyInvestmentModel("2022", 104636243924),
                new YearlyInvestmentModel("2023", 92789053936),
                new YearlyInvestmentModel("2024", 130255020381),
            };

            PublicOfferingData = new ObservableCollection<YearlyInvestmentModel>
            {
                new YearlyInvestmentModel("2013", 1802922859),
                new YearlyInvestmentModel("2014", 2804290536),
                new YearlyInvestmentModel("2015", 2343665250),
                new YearlyInvestmentModel("2016", 2291887711),
                new YearlyInvestmentModel("2017", 2244080913),
                new YearlyInvestmentModel("2018", 13618264280),
                new YearlyInvestmentModel("2019", 6899927340),
                new YearlyInvestmentModel("2020", 21002423108),
                new YearlyInvestmentModel("2021", 37320000000),
                new YearlyInvestmentModel("2022", 9231248137),
                new YearlyInvestmentModel("2023", 4819979608),
                new YearlyInvestmentModel("2024", 4198152391),
            };

            MinorityStakeData = new ObservableCollection<YearlyInvestmentModel>
            {
                new YearlyInvestmentModel("2013", 2244929754),
                new YearlyInvestmentModel("2014", 389166850),
                new YearlyInvestmentModel("2015", 1349036583),
                new YearlyInvestmentModel("2016", 1817704046),
                new YearlyInvestmentModel("2017", 1426041566),
                new YearlyInvestmentModel("2018", 2168994549),
                new YearlyInvestmentModel("2019", 2278777847),
                new YearlyInvestmentModel("2020", 92333185140),
                new YearlyInvestmentModel("2021", 2650000000),
                new YearlyInvestmentModel("2022", 8222014389),
                new YearlyInvestmentModel("2023", 7985870274),
                new YearlyInvestmentModel("2024", 3878539966),
            };

            DoughnutData = new ObservableCollection<InvestmentModel>
            {
                new InvestmentModel("Merger/acquisition", 611156000000, MergerAcquisitionData),
                new InvestmentModel("Private investment", 126744000000, PrivateInvestmentData),
                new InvestmentModel("Public offering", 738502000000, PublicOfferingData),
                new InvestmentModel("Minority stake", 108577000000, MinorityStakeData)
            };

            CustomBrushes = new List<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#6A4C93")),
                new SolidColorBrush(Color.FromArgb("#00C2D1")),
                new SolidColorBrush(Color.FromArgb("#FF6B6B")),
                new SolidColorBrush(Color.FromArgb("#43AA8B")),
            };
        }
    }
}
