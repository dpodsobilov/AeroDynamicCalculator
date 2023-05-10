using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroDynamicCalculator
{
    public partial class Form1 : Form
    {
        const double PI = Math.PI;
        double r, rn, tetha, lc, l, alpha;

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
        public double Lc
        {
            get
            {
                return lc;
            }
            set
            {
                lc = value;
            }
        }
        public double L
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
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

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            alphaValue.Text = trackBar.Value.ToString() + "°";
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            R = Convert.ToDouble(textBoxR.Text);
            Rn = Convert.ToDouble(textBoxRn.Text);
            Tetha = Convert.ToDouble(textBoxTetha.Text) * Math.PI / 180;
            Lc = Convert.ToDouble(textBoxLc.Text);
            L = Convert.ToDouble(textBoxL.Text);
            Alpha = trackBar.Value * Math.PI / 180;

            //
            // counting aerodynamic params for a spherecial segment
            //
            double cynS, cxS, beta, gamma, a;
            double eps = 0.0000000000001;

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
            double cyn = cynS * Math.Pow(rn, 2) + cynC * (1 - Math.Pow(rn * Math.Cos(Tetha), 2));

        }

    }
}
