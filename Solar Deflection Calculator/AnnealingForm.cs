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

namespace Solar_Deflection_Calculator
{
    public partial class AnnealingForm : Form
    {
        public AnnealingForm()
        {
            InitializeComponent();
            Series series = new Series("Spline");
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 3;
            series.ShadowOffset = 2;

            // Populate new series with data 
            series.Points.AddY(67);
            series.Points.AddY(57);
            series.Points.AddY(83);
            series.Points.AddY(23);
            series.Points.AddY(70);
            series.Points.AddY(60);
            series.Points.AddY(90);
            series.Points.AddY(20);

            // Add series into the chart's series collection 
            chart1.Series.Add(series);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AnnealingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
