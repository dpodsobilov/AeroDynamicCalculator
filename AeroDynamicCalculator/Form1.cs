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
        Data data;
    
        public Form1()
        {
            InitializeComponent();
            tabControl.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitilizeCharts();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxR.Text, out _) || !double.TryParse(textBoxRn.Text, out _) || !double.TryParse(textBoxTetha.Text, out _))
            {
                MessageBox.Show("Недопустимые значения параметров. Введите действительные числа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                capsule = new Formulas(Convert.ToDouble(textBoxR.Text), Convert.ToDouble(textBoxRn.Text), Convert.ToDouble(textBoxTetha.Text));
                data = new Data();

                if (Convert.ToDouble(textBoxTetha.Text) < 0.0000000000001)
                {
                    textBoxTetha.Text = "45";
                }

                chartCx.Series[0].Points.Clear();
                chartCy.Series[0].Points.Clear();
                chartM.Series[0].Points.Clear();
                chartMzc.Series[0].Points.Clear();
                chartXD.Series[0].Points.Clear();

                tabControl.Show();
                RestartCharts();
                CalculateValues();
                chartM.Series[0].Points.Clear();
                chartM.Series[0].Points.DataBindXY(data.DictMzn.Keys, data.DictMzn.Values);
            }
        }

        private void InitilizeCharts()
        {
            // configuration for Charts
            // example: chartName.ChartAreas[0].AxisY.Maximum = 100;

            // chart Cx
            chartCx.ChartAreas[0].AxisX.Title = "alpha";
            chartCx.ChartAreas[0].AxisY.Title = "Cx";


            // chart Cy
            chartCy.ChartAreas[0].AxisX.Title = "alpha";
            chartCy.ChartAreas[0].AxisY.Title = "Cy";

            // chart Mzn
            chartM.ChartAreas[0].AxisX.Title = "alpha";
            chartM.ChartAreas[0].AxisY.Title = "Mzn";

            // chart Mzc
            chartMzc.ChartAreas[0].AxisX.Title = "alpha";
            chartMzc.ChartAreas[0].AxisY.Title = "Mzc";

            // chart xD
            chartXD.ChartAreas[0].AxisX.Title = "alpha";
            chartXD.ChartAreas[0].AxisY.Title = "xD";
        }

        // moves graphs to the beginning
        private void RestartCharts()
        {
            // cx
            chartCx.Visible = true;
            chartCx.ChartAreas[0].AxisX.Minimum = 0;
            chartCx.ChartAreas[0].AxisX.Maximum = 180;

            chartCx.ChartAreas[0].AxisX.Interval = 5;


            // cy
            chartCy.Visible = true;
            chartCy.ChartAreas[0].AxisX.Minimum = 0;
            chartCy.ChartAreas[0].AxisX.Maximum = 180;

            chartCy.ChartAreas[0].AxisX.Interval = 5;


            // mzn
            chartM.Visible = true;
            chartM.ChartAreas[0].AxisX.Minimum = 0;
            chartM.ChartAreas[0].AxisX.Maximum = 180;

            chartM.ChartAreas[0].AxisX.Interval = 5;

            // mzc
            chartMzc.Visible = true;
            chartMzc.ChartAreas[0].AxisX.Minimum = 0;
            chartMzc.ChartAreas[0].AxisX.Maximum = 180;

            chartMzc.ChartAreas[0].AxisX.Interval = 5;


            // xd
            chartXD.Visible = true;
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
            

            for (int i = 0; i <= 180; i++)
            {
                data = capsule.CalculateValues(i, eps);

                /*chartCx.Series[0].Points.AddXY(i, capsule.Cx);
                chartCy.Series[0].Points.AddXY(i, capsule.Cyn);
                chartM.Series[0].Points.AddXY(i, capsule.Mzn);
                chartMzc.Series[0].Points.AddXY(i, capsule.Mzc);
                chartXD.Series[0].Points.AddXY(i, capsule.XD);*/

                //sw.WriteLine($"{i}  {cx}");
            }

            //chartM.Series[0].Points.DataBindXY(data.DictMzn.Keys, data.DictMzn.Values);

            //testTab();
            //Close the file
            //sw.Close();
        }

        private void testTab()
        {
            //Control[] controls = tabControl.TabPages[0].Controls.Find("chartM", true);
            //tabControl.TabPages[0].Controls.Remove(chartM);
            tabControl.TabPages[0].Controls.Add(chartM);
            tabControl.TabPages[1].Controls.Remove(chartCy);
            tabControl.TabPages[1].Controls.Add(chartM);
            tabControl.TabPages[2].Controls.Remove(chartCx);
            tabControl.TabPages[2].Controls.Add(chartM);
            //Chart controlChart = (Chart) controls[0];
            //controlChart.Series[0].Points.Clear();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch(tabControl.SelectedIndex)
            {
                // mzn
                case 0:
                    chartM.Series[0].Points.Clear();
                    chartM.ChartAreas[0].AxisY.Title = "Mzn";
                    chartM.Titles.Clear();
                    chartM.Titles.Add("Зависимость Mzn от угла атаки alpha");
                    chartM.Series[0].Points.DataBindXY(data.DictMzn.Keys, data.DictMzn.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chartM);
                    break;

                // Cy
                case 1:
                    chartM.Series[0].Points.Clear();
                    chartM.ChartAreas[0].AxisY.Title = "Cyn";
                    chartM.Titles.Clear();
                    chartM.Titles.Add("Зависимость Cyn от угла атаки alpha");
                    chartM.Series[0].Points.DataBindXY(data.DictCyn.Keys, data.DictCyn.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chartM);
                    chartM.Show();
                    break;

                // Cx
                case 2:
                    chartM.Series[0].Points.Clear();
                    chartM.ChartAreas[0].AxisY.Title = "Cx";
                    chartM.Titles.Clear();
                    chartM.Titles.Add("Зависимость Cx от угла атаки alpha");
                    chartM.Series[0].Points.DataBindXY(data.DictCx.Keys, data.DictCx.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chartM);
                    break;

                // Mzc
                case 3:
                    chartM.Series[0].Points.Clear();
                    chartM.ChartAreas[0].AxisY.Title = "Mzc";
                    chartM.Titles.Clear();
                    chartM.Titles.Add("Зависимость Mzn от угла атаки alpha");
                    chartM.Series[0].Points.DataBindXY(data.DictMzc.Keys, data.DictMzc.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chartM);
                    break;
                
                // xD
                case 4:
                    chartM.Series[0].Points.Clear();
                    chartM.ChartAreas[0].AxisY.Title = "xD";
                    chartM.Titles.Clear();
                    chartM.Titles.Add("Зависимость xD от угла атаки alpha");
                    chartM.Series[0].Points.DataBindXY(data.DictXD.Keys, data.DictXD.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chartM);
                    break;
            }
        }
    }

}
