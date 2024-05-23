using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace Dlouhodobka_Sorting_Algoritms
{
    public partial class Charts : Form
    {
        int element;
        double bubTime;
        double oddTime;
        double quiTime;
        double bogTime;
        double heaTime;

        public Charts(int elements, double bubTimes, double oddTimes,
            double quiTimes, double bogTimes, double heaTimes)
        {
            InitializeComponent();

            element = elements;
            bubTime = bubTimes;
            oddTime = oddTimes;
            quiTime = quiTimes;
            bogTime = bogTimes;
            heaTime = heaTimes;
        }

        public void UpdateData(int elements, double bubTimes, double oddTimes,
            double quiTimes, double bogTimes, double heaTimes)
        {
            element = elements;
            bubTime = bubTimes;
            oddTime = oddTimes;
            quiTime = quiTimes;
            bogTime = bogTimes;
            heaTime = heaTimes;
        }

        #region Loads
        private void Charts_Load(object sender, EventArgs e)
        {
            BubbleChart(element, bubTime, true);
            OddChart(element, oddTime, true);
            QuickChart(element, quiTime, true);
            BogoChart(element, bogTime, true);
            HeapChart(element, heaTime, true);
        }

        public void UpdateCharts()
        {
            BubbleChart(element, bubTime, false);
            OddChart(element, oddTime, false);
            QuickChart(element, quiTime, false);
            BogoChart(element, bogTime, false);
            HeapChart(element, heaTime, false);
        }

        public void DisableCharts(bool bub, bool odd, bool qui, bool bog, bool hea)
        {
            if (bub)
                chart1.Visible = false;
            if (odd)
                chart2.Visible = false;
            if (qui)
                chart3.Visible = false;
            if (bog)
                chart4.Visible = false;
            if (hea)
                chart5.Visible = false;
        }

        #endregion

        #region Charts
        void BubbleChart(int elements, double time, bool check) 
        {
            if (check)
            {
                Series series1 = chart1.Series.Add("Bubble Sort");
                series1.ChartType = SeriesChartType.Spline;
                series1.Name = "Bubble Sort";
                series1.IsXValueIndexed = true;
                series1.IsVisibleInLegend = false;
            }

            chart1.Legends[0].Enabled = false;
            chart1.Series["Bubble Sort"].Points.AddXY(elements, time);
            chart1.Update();
        }
        void OddChart(int elements, double time, bool check)
        {
            if (check)
            {
                Series series2 = chart2.Series.Add("Odd-Even Sort");
                series2.ChartType = SeriesChartType.Spline;
                series2.Name = "Odd-Even Sort";
                series2.IsXValueIndexed = true;
                series2.IsVisibleInLegend = false;
            }

            chart2.Legends[0].Enabled = false;
            chart2.Series["Odd-Even Sort"].Points.AddXY(elements, time);
            chart2.Update();
        }
        void QuickChart(int elements, double time, bool check)
        {
            if (check)
            {
                Series series3 = chart3.Series.Add("Quick Sort");
                series3.ChartType = SeriesChartType.Spline;
                series3.Name = "Quick Sort";
                series3.IsXValueIndexed = true;
                series3.IsVisibleInLegend = false;
            }

            chart3.Legends[0].Enabled = false;
            chart3.Series["Quick Sort"].Points.AddXY(elements, time);
            chart3.Update();
        }
        void BogoChart(int elements, double time, bool check)
        {
            if (check)
            {
                Series series4 = chart4.Series.Add("Bogo Sort");
                series4.ChartType = SeriesChartType.Spline;
                series4.Name = "Bogo Sort";
                series4.IsXValueIndexed = true;
                series4.IsVisibleInLegend = false;
            }
            chart4.Legends[0].Enabled = false;
            chart4.Series["Bogo Sort"].Points.AddXY(elements, time);
            chart4.Update();
        }
        void HeapChart(int elements, double time, bool check)
        {
            if (check)
            {
                Series series5 = chart5.Series.Add("Heap Sort");
                series5.ChartType = SeriesChartType.Spline;
                series5.Name = "Heap Sort";
                series5.IsXValueIndexed = true;
                series5.IsVisibleInLegend = false;
            }

            chart5.Legends[0].Enabled = false;
            chart5.Series["Heap Sort"].Points.AddXY(elements, time);
            chart5.Update();
        }
        #endregion
    }
}
