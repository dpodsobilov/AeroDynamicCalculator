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
        const double PI = Math.PI;
        double r, rn, tetha, alpha;
        double cyn, cx, mzn;


        public double R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        public double Rn
        {
            get
            {
                return rn;
            }
            set
            {
                rn = value;
            }
        }
        public double Tetha
        {
            get
            {
                return tetha;
            }
            set
            {
                tetha = value;
            }
        }

        public double Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

            restartCharts();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            R = Convert.ToDouble(textBoxR.Text);
            Rn = Convert.ToDouble(textBoxRn.Text);
            Tetha = Convert.ToDouble(textBoxTetha.Text) * PI / 180;

            chartCx.Series[0].Points.Clear();
            chartCy.Series[0].Points.Clear();
            chartM.Series[0].Points.Clear();
            chartMzc.Series[0].Points.Clear();
            chartXD.Series[0].Points.Clear();

            restartCharts();
            calculateValues();
        }

        // moves graph to the beginning
        private void restartCharts()
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

        private void calculateValues()
        {
            //
            // counting aerodynamic params for a spherecial segment
            //
            double cynS, cxS, beta, gamma, a;
            double eps = 0.0000000000001;

            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter("C:\\Users\\Denis\\Desktop\\directory\\Test.txt");
            

            for (double i = 0; i <= 180; i++)
            {
                Alpha = i * PI / 180;

                beta = Math.Asin(Math.Tan(Tetha) / Math.Tan(Alpha));

                // 0 <= Alpha <= Tetha
                if (Alpha >= eps && Alpha <= Tetha)
                {
                    cynS = 0.5 * Math.Pow(Math.Cos(Tetha), 4) * Math.Sin(2 * Alpha);
                    cxS = 2 * Math.Pow(Math.Cos(Tetha), 2) * (1 - 0.5 * Math.Pow(Math.Cos(Tetha), 2)
                       - (1 - 0.75 * Math.Pow(Math.Cos(Tetha), 2)) * Math.Pow(Math.Sin(Alpha), 2));
                }
                // Tetha < Alpha <= PI/2
                else
                {
                    gamma = Math.Acos(Math.Sin(Tetha) / Math.Sin(Alpha));
                    a = Math.Sqrt(Math.Pow(Math.Sin(Alpha), 2) - Math.Pow(Math.Sin(Tetha), 2));

                    cynS = 0.25 * Math.Pow(Math.Cos(Tetha), 4) * Math.Sin(2 * Alpha) * (1 + 2 * beta / PI)
                        + gamma * Math.Sin(Alpha) / PI + (1 / (3 * PI)) * Math.Sin(Alpha) * Math.Sin(Tetha)
                        * (Math.Pow(Math.Sin(Tetha), 2) * (3 - Math.Pow(Math.Sin(Alpha), -2))) * a;

                    cxS = (1 + 2 * beta / PI) * (1 - 0.5 * Math.Pow(Math.Cos(Tetha), 2)
                       - (1 - 0.75 * Math.Pow(Math.Cos(Tetha), 2)) * Math.Pow(Math.Sin(Alpha), 2))
                       * Math.Pow(Math.Cos(Tetha), 2) + gamma * Math.Cos(Alpha) / PI
                       + (Math.Cos(Alpha) / (2 * PI)) * Math.Sin(Tetha)
                       * (1 - 3 * Math.Pow(Math.Sin(Tetha), 2)) * a;
                }


                //
                // counting aerodynamic params for a truncated cone
                //

                double cynC, cxC;

                // 0 <= Alpha <= Tetha
                if (Alpha >= eps && Alpha <= Tetha)
                {
                    cynC = 0.5 * Math.Pow(Math.Cos(Tetha), 2) * Math.Sin(2 * Alpha);
                    cxC = 2 * Math.Pow(Math.Sin(Tetha), 2) + (1 - 3 * Math.Pow(Math.Sin(Tetha), 2))
                        * Math.Pow(Math.Sin(Alpha), 2);
                }
                // Tetha < Alpha <= PI/2
                else
                {
                    double tangens = Math.Tan(Tetha) / Math.Tan(Alpha);
                    cynC = 0.5 * Math.Pow(Math.Cos(Tetha), 2) * Math.Sin(2 * Alpha)
                        * (1 + 2 * beta / PI + (2 / (3 * PI))
                        * Math.Sqrt(1 - Math.Pow(tangens, 2)) * (2 * tangens + Math.Pow(tangens, -1)));
                    cxC = 0.5 * (1 + 2 * beta / PI)
                        * (2 * Math.Pow(Math.Sin(Tetha), 2) + (1 - 3 * Math.Pow(Math.Sin(Tetha), 2))
                        * Math.Pow(Math.Sin(Alpha), 2)) + (0.75 / PI) * Math.Sqrt(1 - Math.Pow(tangens, 2))
                        * Math.Sin(2 * Alpha) * Math.Sin(2 * Tetha);
                }

                //
                // counting cone with sperical segnent
                //

                double rn = Rn / R;
                cyn = cynS * Math.Pow(rn, 2) + cynC * (1 - Math.Pow(rn * Math.Cos(Tetha), 2));
                cx = -cxS * Math.Pow(rn, 2) - cxC * (1 - Math.Pow(rn * Math.Cos(Tetha), 2));


                // capsule length
                double L = R / Math.Tan(Tetha) + Rn - Rn / Math.Sin(Tetha);
                // truncated cone length
                double Lc = (R - Rn * Math.Cos(Tetha)) * (1.0 / Math.Tan(Tetha));

                double L0 = L / R * Math.Tan(Tetha);

                double RL = Rn / R * Math.Cos(Tetha);
                // value interpretates the center of truncated cone
                double xd = 2 / (3 * Math.Pow(Math.Cos(Tetha), 2)) *
                    ((1 + RL + RL * RL) / (1 - RL * RL)) - RL / (1 - RL);

                mzn = -cynS * Math.Tan(Tetha) / L0 * Math.Pow(rn, 3)
                    - cynC / L0 * (1 - Math.Pow(rn * Math.Cos(Tetha), 2))
                    * (xd * Lc / L + (1 - Lc / L));

                // !!!!! I have question!!!! 
                double xC = -1;
                //

                double mzc = mzn - cyn * xC;
                double xD = mzn / cyn;


                chartCx.Series[0].Points.AddXY(i, cx);
                chartCy.Series[0].Points.AddXY(i, cyn);
                chartM.Series[0].Points.AddXY(i, mzn);
                chartMzc.Series[0].Points.AddXY(i, mzc);
                chartXD.Series[0].Points.AddXY(i, xD);

                sw.WriteLine($"{i}  {cx}");
            }

            //Close the file
            sw.Close();
        }

        
    }
}
