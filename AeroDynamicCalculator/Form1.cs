using AeroDynamicCalculator.helpers;
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
            this.Width = 630;
            openFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitilizeChart();
            AddHelpButton();
            AddAboutButton();
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
            chart.ChartAreas[0].AxisX.Maximum = 90;
            chart.ChartAreas[0].AxisX.Interval = 2.5;
        }

        private void CalculateValues()
        {
            //
            // counting aerodynamic params for a spherecial segment
            //
            double eps = 0.0000000000001;

            for (int i = 0; i < 90; i++)
            {
                data = capsule.CalculateValues(i, eps);
            }
            saveToExcelButton.Visible = true;
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

                // производная cyv
                case 7:
                    chart.Series[0].Points.Clear();
                    chart.ChartAreas[0].AxisY.Title = "Производная коэффициента подъемной силы cyv";
                    chart.Titles.Clear();
                    chart.Titles.Add("Зависимость производной cyv от угла атаки alpha");
                    chart.Series[0].Points.DataBindXY(data.DictCyvDer.Keys, data.DictCyvDer.Values);
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
            try
            {
                string r, rn, tetha;
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    try
                    {
                        r = streamReader.ReadLine().Trim();
                        rn = streamReader.ReadLine().Trim();
                        tetha = streamReader.ReadLine().Trim();
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Ошибка открытия файла модели. Описание: " + ex.Message);
                        throw new Exception("Ошибка открытия файла модели. Описание: " + ex.Message);
                    }

                }

                if (double.TryParse(r, out _) && double.TryParse(rn, out _) && double.TryParse(tetha, out _))
                {
                    textBoxR.Text = r;
                    textBoxRn.Text = rn;
                    textBoxTetha.Text = tetha;
                }
                else throw new Exception("Неверные значения модели");
                    
                MessageBox.Show("Файл открыт");
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка открытия файла модели. Описание: " + ex.Message);
            }
        }

        private void saveModelClick(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
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

        private void saveToCSVButton_Click(object sender, EventArgs e)
        {
            
            saveFileDialog.Filter = "Книга Excel (*.xlxs)|*.xlsx|Книга Excel 97-2003 (*.xls)|*.xls|Все файлы(*.*)|*.*";
            
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            string result = ExcelSaver.SaveToExcel(filename, data, capsule);
            
            if (result.Equals("SUCCESS"))
            {
                MessageBox.Show("Успешно сохранено", "Сохранение графиков", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(result, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddHelpButton()
        {
            // Create a new button
            ToolStripButton helpButton = new ToolStripButton();
            helpButton.Text = "Справка";
            helpButton.Click += HelpButton_Click; // Add event handler for button click

            // Add the button to the ToolStrip
            menuStrip.Items.Add(helpButton);
        }

        private void AddAboutButton()
        {
            // Create a new button
            ToolStripButton aboutButton = new ToolStripButton();
            aboutButton.Text = "О системе";
            aboutButton.Click += AboutButton_Click; // Add event handler for button click

            // Add the button to the ToolStrip
            menuStrip.Items.Add(aboutButton);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            // Handle button click event to open the HTML file
            string pathToHelpFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + @"\help\about.html";

            try
            {
                System.Diagnostics.Process.Start(pathToHelpFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message + " " + Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + @"\help\about.html");
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            // Handle button click event to open the HTML file
            string pathToHelpFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + @"\help\help.html";

            try
            {
                System.Diagnostics.Process.Start(pathToHelpFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message + " " + Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + @"\help\help.html");
            }
        }
    }

}
