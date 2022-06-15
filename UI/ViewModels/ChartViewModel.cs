using BLL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using UI.Views;

namespace UI.ViewModels
{
    public class ChartModel
    {
        public string key { get; set; }
        public int value { get; set; }
    }

    public class ChartViewModel : IViewModel
    {
        ChartView chartView;
        BillRepository billRepository = new BillRepository();
        List<Bill> bills;
        List<int> years = new List<int>();
        List<int> months = new List<int>();
        List<ChartModel> data;
        Series chart = new Series();
        public ChartViewModel(ChartView chartView)
        {
            this.chartView = chartView;
            this.chart = chartView.chartIncome.Series["Income"];
            LoadAsync();
        }

        private async void LoadAsync()
        {
            var _bills = await billRepository.GetAllAsync();
            bills = new List<Bill>(_bills);
            years = bills.Select(b => b.dateOfPayment.Year).Distinct().ToList();
            months = Enumerable.Range(1, 12).ToList();
            LoadEvent();
        }

        private void LoadEvent()
        {
            chartView.cbbChartType.DataSource = null;
            chartView.cbbChartType.DataSource = Enum.GetValues(typeof(SeriesChartType));
            chartView.cbbChartType.SelectedItem = SeriesChartType.Column;
            chartView.cbbChartType.SelectedIndexChanged -= CbbChartType_SelectedIndexChanged;
            chartView.cbbChartType.SelectedIndexChanged += CbbChartType_SelectedIndexChanged;
            
            chartView.cbbYear.Items.Clear();
            chartView.cbbYear.Items.Add("All");
            chartView.cbbYear.Items.AddRange(years.Select(y => "Năm " + y.ToString()).ToArray());
            chartView.cbbYear.SelectedIndexChanged -= CbbYear_SelectedIndexChanged;
            chartView.cbbYear.SelectedIndexChanged += CbbYear_SelectedIndexChanged;
            chartView.cbbYear.SelectedIndex = 0;

            chartView.cbbMonth.Items.Clear();
            chartView.cbbMonth.Items.Add("All");
            chartView.cbbMonth.Items.AddRange(months.Select(m => "Tháng " + m.ToString()).ToArray());
            chartView.cbbMonth.SelectedIndexChanged += CbbMonth_SelectedIndexChanged; 
            chartView.cbbMonth.SelectedIndexChanged += CbbMonth_SelectedIndexChanged;
            chartView.cbbMonth.SelectedIndex = 0;
        }

        private void CbbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.ChartType = (SeriesChartType)chartView.cbbChartType.SelectedItem;
        }

        private void CbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void CbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            data = new List<ChartModel>();
            var indexYear = chartView.cbbYear.SelectedIndex;
            if(indexYear == 0)
            {
                data.AddRange(years.Select(y => new ChartModel()
                {
                    key = "Năm " + y.ToString(),
                    value = bills.Where(b => b.dateOfPayment.Year == y).Sum(b => b.total)
                }));
                chartView.cbbMonth.Enabled = false;
                DrawChart("Doanh thu các năm");
                return;
            }

            chartView.cbbMonth.Enabled = true;
            var year = years[indexYear - 1];
            var indexMonth = chartView.cbbMonth.SelectedIndex;
            if(indexMonth == 0)
            {
                data.AddRange(months.Select(m => new ChartModel()
                {
                    key = "Tháng " + m.ToString(),
                    value = bills.Where(b => b.dateOfPayment.Year == year
                        && b.dateOfPayment.Month == m).Sum(b => b.total)
                }));
                DrawChart("Doanh thu năm " + year.ToString());
                return;
            }

            var month = months[indexMonth - 1];
            var days = Enumerable.Range(1, DateTime.DaysInMonth(year, month)).ToList();
            data.AddRange(days.Select(d => new ChartModel()
            {
                key = "Ngày " + d.ToString(),
                value = bills.Where(b => b.dateOfPayment.Day == d
                    && b.dateOfPayment.Month == month
                    && b.dateOfPayment.Year == year).Sum(b => b.total)
            }));
            DrawChart("Doanh thu tháng " + month.ToString());
        }

        private void DrawChart(string title)
        {
            chartView.chartIncome.DataSource = data;
            chartView.chartIncome.Titles.Clear();
            chartView.chartIncome.Titles.Add(title);
            chart.XValueMember = "key";
            chart.YValueMembers = "value";            
        }
    }
}
