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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.Width = 620;
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitilizeChart();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxR.Text, out _) || !double.TryParse(textBoxRn.Text, out _) || !double.TryParse(textBoxTetha.Text, out _))
            {
                MessageBox.Show("Недопустимые значения параметров. Введите действительные числа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Width = 1337;
                CenterToScreen();
                capsule = new Formulas(Convert.ToDouble(textBoxR.Text), Convert.ToDouble(textBoxRn.Text), Convert.ToDouble(textBoxTetha.Text));
                data = new Data();

                if ((Convert.ToDouble(textBoxTetha.Text) % 360) < 0.0000000000001)
                {
                    textBoxTetha.Text = "45";
                }

                chart.Series[0].Points.Clear();

                tabControl.Show();
                RestartCharts();
                CalculateValues();
                chart.Series[0].Points.Clear();
                chart.Series[0].Points.DataBindXY(data.DictMzn.Keys, data.DictMzn.Values);
            }
        }

        private void InitilizeChart()
        {
            chart.ChartAreas[0].AxisX.Title = "alpha";
            chart.ChartAreas[0].AxisY.Title = "Mzn";
        }

        // moves graphs to the beginning
        private void RestartCharts()
        {
            chart.Visible = true;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 180;
            chart.ChartAreas[0].AxisX.Interval = 5;
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
                //sw.WriteLine($"{i}  {cx}");
            }

            //Close the file
            //sw.Close();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch(tabControl.SelectedIndex)
            {
                // mzn
                case 0:
                    chart.Series[0].Points.Clear();
                    chart.ChartAreas[0].AxisY.Title = "Mzn";
                    chart.Titles.Clear();
                    chart.Titles.Add("Зависимость Mzn от угла атаки alpha");
                    chart.Series[0].Points.DataBindXY(data.DictMzn.Keys, data.DictMzn.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chart);
                    break;

                // Cy
                case 1:
                    chart.Series[0].Points.Clear();
                    chart.ChartAreas[0].AxisY.Title = "Cyn";
                    chart.Titles.Clear();
                    chart.Titles.Add("Зависимость Cyn от угла атаки alpha");
                    chart.Series[0].Points.DataBindXY(data.DictCyn.Keys, data.DictCyn.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chart);
                    chart.Show();
                    break;

                // Cx
                case 2:
                    chart.Series[0].Points.Clear();
                    chart.ChartAreas[0].AxisY.Title = "Cx";
                    chart.Titles.Clear();
                    chart.Titles.Add("Зависимость Cx от угла атаки alpha");
                    chart.Series[0].Points.DataBindXY(data.DictCx.Keys, data.DictCx.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chart);
                    break;

                // Mzc
                case 3:
                    chart.Series[0].Points.Clear();
                    chart.ChartAreas[0].AxisY.Title = "Mzc";
                    chart.Titles.Clear();
                    chart.Titles.Add("Зависимость Mzn от угла атаки alpha");
                    chart.Series[0].Points.DataBindXY(data.DictMzc.Keys, data.DictMzc.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chart);
                    break;
                
                // xD
                case 4:
                    chart.Series[0].Points.Clear();
                    chart.ChartAreas[0].AxisY.Title = "xD";
                    chart.Titles.Clear();
                    chart.Titles.Add("Зависимость xD от угла атаки alpha");
                    chart.Series[0].Points.DataBindXY(data.DictXD.Keys, data.DictXD.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chart);
                    break;
                    
                // cxv
                case 5:
                    chart.Series[0].Points.Clear();
                    chart.ChartAreas[0].AxisY.Title = "Коэффициент лобового сопротивления cxv";
                    chart.Titles.Clear();
                    chart.Titles.Add("Зависимость cxv от угла атаки alpha");
                    chart.Series[0].Points.DataBindXY(data.DictCxv.Keys, data.DictCxv.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chart);
                    break;

                // cyv
                case 6:
                    chart.Series[0].Points.Clear();
                    chart.ChartAreas[0].AxisY.Title = "Коэффициент подъемной силы cyv";
                    chart.Titles.Clear();
                    chart.Titles.Add("Зависимость cyv от угла атаки alpha");
                    chart.Series[0].Points.DataBindXY(data.DictCyv.Keys, data.DictCyv.Values);
                    tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(chart);
                    break;
            }
        }

        private void loadModelClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            using (StreamReader streamReader = new StreamReader(filename))
            {
                textBoxR.Text = streamReader.ReadLine();
                textBoxRn.Text = streamReader.ReadLine();
                textBoxTetha.Text = streamReader.ReadLine();
            }
            MessageBox.Show("Файл открыт");
        }

        private void saveModelClick(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog.FileName;
            using (StreamWriter streamWriter = new StreamWriter(filename))
            {
                streamWriter.WriteLine(textBoxR.Text.Trim());
                streamWriter.WriteLine(textBoxRn.Text.Trim());
                streamWriter.WriteLine(textBoxTetha.Text.Trim());
            }
            MessageBox.Show("Файл сохранен");
        }
    }

}
