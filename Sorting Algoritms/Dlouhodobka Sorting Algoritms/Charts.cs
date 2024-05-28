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
using System.Runtime.InteropServices;

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

        bool bubSort = true;
        bool oddSort = true;
        bool quiSort = true;
        bool bogSort = true;
        bool heaSort = true;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Charts(int elements, double bubTimes, double oddTimes,
            double quiTimes, double bogTimes, double heaTimes)
        {
            InitializeComponent();

            this.Size = new Size(1820, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Resize += new EventHandler(Form_Resize);


            element = elements;
            bubTime = bubTimes;
            oddTime = oddTimes;
            quiTime = quiTimes;
            bogTime = bogTimes;
            heaTime = heaTimes;

            Chart[] charts = { chart1, chart2, chart3, chart4, chart5, chart6 };

            for (int i = 0; i < 6; i++)
                CustomizeChartProperties(charts[i]);

            ArrangeCharts();

        }

        private void CustomizeChartProperties(Chart chart)
        {
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = SystemColors.ScrollBar;

            chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = SystemColors.ScrollBar;
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
        public void Charts_Load(object sender, EventArgs e)
        {
            BubbleChart(element, bubTime, true);
            OddChart(element, oddTime, true);
            QuickChart(element, quiTime, true);
            BogoChart(element, bogTime, true);
            HeapChart(element, heaTime, true);
            AllChart(element, bubTime, oddTime, quiTime, bogTime, heaTime, true);
        }

        public void UpdateCharts()
        {
            BubbleChart(element, bubTime, false);
            OddChart(element, oddTime, false);
            QuickChart(element, quiTime, false);
            BogoChart(element, bogTime, false);
            HeapChart(element, heaTime, false);
            AllChart(element, bubTime, oddTime, quiTime, bogTime, heaTime, false);
        }

        public void DisableCharts(bool bub, bool odd, bool qui, bool bog, bool hea)
        {

            bubSort = !bub;
            oddSort = !odd;
            quiSort = !qui;
            bogSort = !bog;
            heaSort = !hea;

            ArrangeCharts();
        }

        private void ArrangeCharts()
        {
            List<Chart> visibleCharts = new List<Chart>();

            if (bubSort) visibleCharts.Add(chart1);
            if (oddSort) visibleCharts.Add(chart2);
            if (quiSort) visibleCharts.Add(chart3);
            if (bogSort) visibleCharts.Add(chart4);
            if (heaSort) visibleCharts.Add(chart5);
            visibleCharts.Add(chart6);

            int chartWidth = this.ClientSize.Width / visibleCharts.Count;
            int chartHeight = this.ClientSize.Height;

            for (int i = 0; i < visibleCharts.Count; i++)
            {
                visibleCharts[i].Visible = true;
                visibleCharts[i].SetBounds(i * chartWidth, 0, chartWidth, chartHeight);
            }

                foreach (var chart in new[] { chart1, chart2, chart3, chart4, chart5 })
                {
                    if (!visibleCharts.Contains(chart))
                    {
                        chart.Visible = false;
                    }
                }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            ArrangeCharts();
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
                series1.Color = Color.Blue;
            }

            chart1.Legends[0].Enabled = false;
            chart1.Series["Bubble Sort"].BorderWidth = 3;
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
                series2.Color = Color.Gold;
            }

            chart2.Legends[0].Enabled = false;
            chart2.Series["Odd-Even Sort"].BorderWidth = 3;
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
                series3.Color = Color.Red;
            }

            chart3.Legends[0].Enabled = false;
            chart3.Series["Quick Sort"].BorderWidth = 3;
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
                series4.Color = Color.Pink;
            }
            chart4.Legends[0].Enabled = false;
            chart4.Series["Bogo Sort"].BorderWidth = 3;
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
                series5.Color = Color.LightGray;
            }

            chart5.Legends[0].Enabled = false;
            chart5.Series["Heap Sort"].BorderWidth = 3;
            chart5.Series["Heap Sort"].Points.AddXY(elements, time);
            chart5.Update();
        }
        void AllChart(int elements, double bubTime, double oddTime, double quiTime, double bogTime, double heaTime, bool check)
        {
            if (check)
                UpdateAllCharts();
            else
            {
                UpdateSeriesInChart(chart6, "Bubble Sort", elements, bubTime);
                UpdateSeriesInChart(chart6, "Odd-Even Sort", elements, oddTime);
                UpdateSeriesInChart(chart6, "Quick Sort", elements, quiTime);
                UpdateSeriesInChart(chart6, "Bogo Sort", elements, bogTime);
                UpdateSeriesInChart(chart6, "Heap Sort", elements, heaTime);
            }

            chart6.Update();
        }

        void AddSeriesToChart(Chart chart, string seriesName, int elements, double time, Color color)
        {
            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 3,
                IsXValueIndexed = true,
                IsVisibleInLegend = false
            };
            series.Points.AddXY(elements, time);
            series.Color = color;
            chart.Series.Add(series);
        }

        void UpdateSeriesInChart(Chart chart, string seriesName, int elements, double time)
        {
            if (chart.Series.IndexOf(seriesName) != -1)
            {
                chart.Series[seriesName].Points.AddXY(elements, time);
            }
        }

        void UpdateAllCharts()
        {
            chart6.Series.Clear();

            if (bubSort)
                AddSeriesToChart(chart6, "Bubble Sort", element, bubTime, Color.Blue);
            if (oddSort)
                AddSeriesToChart(chart6, "Odd-Even Sort", element, oddTime, Color.Gold);
            if (quiSort)
                AddSeriesToChart(chart6, "Quick Sort", element, quiTime, Color.Red);
            if (bogSort)
                AddSeriesToChart(chart6, "Bogo Sort", element, bogTime, Color.Pink);
            if (heaSort)
                AddSeriesToChart(chart6, "Heap Sort", element, heaTime, Color.LightGray);

            chart6.Update();
        }

        #endregion

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
