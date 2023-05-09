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
            
            if (Alpha >= eps && Alpha <= Tetha)
            {
                cynS = 0.5 * Math.Pow(Math.Cos(Tetha), 4) * Math.Sin(2 * Alpha);
                cxS = 2 * Math.Pow(Math.Cos(Tetha), 2) * (1 - 0.5 * Math.Pow(Math.Cos(Tetha), 2) -
                     (1 - 0.75 * Math.Pow(Math.Cos(Tetha), 2)) * Math.Pow(Math.Sin(Alpha), 2));
            }
            else 
            {

            }
        }

    }
}
