using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PingAnalizer
{
    /// <summary>
    /// Main form class.
    /// </summary>
    public partial class FmLogAnalizer : Form
    {
        private const string Title = "Ping statistics ";

        public const int WMNCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        /// <summary>
        /// Initializes a new instance of the <see cref="FmLogAnalizer"/> class.
        /// </summary>
        public FmLogAnalizer()
        {
            this.InitializeComponent();
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(
            IntPtr hWnd,
            int mssg,
            int wParam,
            int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BtSelectFirtsFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string filePath = openFileDialog1.FileName;
                this.tb1FilePath.Text = filePath;
                AddChartTitle(ref chart1, openFileDialog1.SafeFileName);
            }
        }

        private void BtSelect2File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string filePath = openFileDialog1.FileName;
                this.tb2FilePath.Text = filePath;
                AddChartTitle(ref chart2, openFileDialog1.SafeFileName);
            }
        }

        private void BtSelect3File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string filePath = openFileDialog1.FileName;
                this.tb3FilePath.Text = filePath;
                AddChartTitle(ref chart3, openFileDialog1.SafeFileName);
            }
        }

        private void AddChartTitle(ref Chart chart, string title)
        {
            if (chart.Titles.Count > 0)
            {
                chart.Titles[0].Text = $"{Title}: {title}";
            }
            else
            {
                chart.Titles.Add($"{Title}: {title}");
            }

            chart.Titles[0].ForeColor = Color.WhiteSmoke;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            const string SeriesDataName1 = "StatGaph1";
            const string SeriesDataName2 = "StatGaph2";
            const string SeriesDataName3 = "StatGaph3";

            if (!string.IsNullOrEmpty(tb1FilePath.Text))
            {
                List<LogData> data1 = new List<LogData>();
                FillData(data1, this.tb1FilePath.Text);
                FillChart(ref chart1, SeriesDataName1, data1);
            }

            if (!string.IsNullOrEmpty(tb2FilePath.Text))
            {
                List<LogData> data2 = new List<LogData>();
                FillData(data2, this.tb2FilePath.Text);
                FillChart(ref chart2, SeriesDataName2, data2);
            }

            if (!string.IsNullOrEmpty(tb3FilePath.Text))
            {
                List<LogData> data3 = new List<LogData>();
                FillData(data3, this.tb3FilePath.Text);
                FillChart(ref chart3, SeriesDataName3, data3);
            }
        }

        /// <summary>
        /// Fill list from log-files.
        /// </summary>
        /// <param name="data">
        /// Logs.
        /// </param>
        /// <param name="dataFilePath">
        /// Path with logs.
        /// </param>
        private void FillData(List<LogData> data, string dataFilePath)
        {
            string[] arr = File.ReadAllLines(dataFilePath).ToArray();

            for (ushort i = 0; i < (ushort)arr.Length; ++i)
            {
                ushort.TryParse(arr[i].Split(';')[1], out ushort delyTime);
                data.Add(new LogData(arr[i].Split(';')[0], delyTime));
            }
        }

        /// <summary>
        /// Fill charts.
        /// </summary>
        /// <param name="chart">
        /// Chart for filling.
        /// </param>
        /// <param name="name">
        /// Name series of chart.
        /// </param>
        /// <param name="data">
        /// Logs data.
        /// </param>
        private void FillChart(ref Chart chart, string name, List<LogData> data)
        {
            chart.Series[name].Points.Clear();
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Minutes;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = false;

            for (int i = 0; i < data.Count; i++)
            {
                chart.Series[name].Points.AddXY(data[i].Time, data[i].DelayTime);
            }
        }

        private void FmLogAnalizer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WMNCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }
    }
}
