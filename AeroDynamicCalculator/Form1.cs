using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AeroDynamicCalculator
{
    public partial class Form1 : Form
    {
        Formulas capsule;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitilizeCharts();
            RestartCharts();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            double checkR, checkRn, checkTetha;
            if (!double.TryParse(textBoxR.Text, out checkR) || !double.TryParse(textBoxRn.Text, out checkRn) || !double.TryParse(textBoxTetha.Text, out checkTetha))
            {
                MessageBox.Show("Недопустимые значения параметров. Введите действительные числа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                capsule = new Formulas(Convert.ToDouble(textBoxR.Text), Convert.ToDouble(textBoxRn.Text), Convert.ToDouble(textBoxTetha.Text));

                if (Convert.ToDouble(textBoxTetha.Text) < 0.0000000000001)
                {
                    textBoxTetha.Text = "45";
                }

                chartCx.Series[0].Points.Clear();
                chartCy.Series[0].Points.Clear();
                chartM.Series[0].Points.Clear();
                chartMzc.Series[0].Points.Clear();
                chartXD.Series[0].Points.Clear();

                RestartCharts();
                CalculateValues();
            }
        }

        private void InitilizeCharts()
        {
            // configuration for Charts
            // example: chartName.ChartAreas[0].AxisY.Maximum = 100;

            // chart Cx
            chartCx.ChartAreas[0].AxisX.LabelStyle.Format = "n3";
            chartCx.ChartAreas[0].AxisX.Title = "alpha";
            chartCx.ChartAreas[0].AxisY.Title = "Cx";
            chartCx.Series[0].XValueType = ChartValueType.Double;


            // chart Cy
            chartCy.ChartAreas[0].AxisX.LabelStyle.Format = "n3";
            chartCy.ChartAreas[0].AxisX.Title = "alpha";
            chartCy.ChartAreas[0].AxisY.Title = "Cy";
            chartCy.Series[0].XValueType = ChartValueType.Double;

            // chart Mzn
            chartM.ChartAreas[0].AxisX.LabelStyle.Format = "n3";
            chartM.ChartAreas[0].AxisX.Title = "alpha";
            chartM.ChartAreas[0].AxisY.Title = "Mzn";
            chartM.Series[0].XValueType = ChartValueType.Double;

            // chart Mzc
            chartMzc.ChartAreas[0].AxisX.LabelStyle.Format = "n3";
            chartMzc.ChartAreas[0].AxisX.Title = "alpha";
            chartMzc.ChartAreas[0].AxisY.Title = "Mzc";
            chartMzc.Series[0].XValueType = ChartValueType.Double;

            // chart xD
            chartXD.ChartAreas[0].AxisX.LabelStyle.Format = "n3";
            chartXD.ChartAreas[0].AxisX.Title = "alpha";
            chartXD.ChartAreas[0].AxisY.Title = "xD";
            chartXD.Series[0].XValueType = ChartValueType.Double;
        }

        // moves graphs to the beginning
        private void RestartCharts()
        {
            // cx
            chartCx.ChartAreas[0].AxisX.Minimum = 0;
            chartCx.ChartAreas[0].AxisX.Maximum = 180;

            chartCx.ChartAreas[0].AxisX.Interval = 5;


            // cy
            chartCy.ChartAreas[0].AxisX.Minimum = 0;
            chartCy.ChartAreas[0].AxisX.Maximum = 180;

            chartCy.ChartAreas[0].AxisX.Interval = 5;


            // mzn
            chartM.ChartAreas[0].AxisX.Minimum = 0;
            chartM.ChartAreas[0].AxisX.Maximum = 180;

            chartM.ChartAreas[0].AxisX.Interval = 5;

            // mzc
            chartMzc.ChartAreas[0].AxisX.Minimum = 0;
            chartMzc.ChartAreas[0].AxisX.Maximum = 180;

            chartMzc.ChartAreas[0].AxisX.Interval = 5;


            // xd
            chartXD.ChartAreas[0].AxisX.Minimum = 0;
            chartXD.ChartAreas[0].AxisX.Maximum = 180;

            chartXD.ChartAreas[0].AxisX.Interval = 5;
        }

        private void CalculateValues()
        {
            //
            // counting aerodynamic params for a spherecial segment
            //
            double eps = 0.0000000000001;

            //Pass the filepath and filename to the StreamWriter Constructor
            //StreamWriter sw = new StreamWriter("C:\\Users\\Denis\\Desktop\\directory\\Test.txt");


            for (double i = 0; i <= 180; i++)
            {
                capsule.CalculateValues(i, eps);

                chartCx.Series[0].Points.AddXY(i, capsule.Cx);
                chartCy.Series[0].Points.AddXY(i, capsule.Cyn);
                chartM.Series[0].Points.AddXY(i, capsule.Mzn);
                chartMzc.Series[0].Points.AddXY(i, capsule.Mzc);
                chartXD.Series[0].Points.AddXY(i, capsule.XD);

                //sw.WriteLine($"{i}  {cx}");
            }
        }

        //Close the file
        //sw.Close();
    }

}
