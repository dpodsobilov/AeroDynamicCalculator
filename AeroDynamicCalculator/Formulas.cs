using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroDynamicCalculator
{
    class Formulas
    {
        // constants
        const double PI = Math.PI;

        // input values
        double r, rn, tetha, alpha;
        double cyn, cx, mzn, mzc, xD;

        public double R
        {
            get
            {
                return r;
            }
        }
        public double Rn
        {
            get
            {
                return rn;
            }
        }
        public double Tetha
        {
            get
            {
                return tetha;
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

        public double Cyn
        {
            get
            {
                return cyn;
            }
        }
        public double Cx
        {
            get
            {
                return cx;
            }
        }
        public double Mzn
        {
            get
            {
                return mzn;
            }
        }
        public double Mzc
        {
            get
            {
                return mzc;
            }
        }
        public double XD
        {
            get
            {
                return xD;
            }
        }

        public Formulas()
        {
            r = 0.4;
            rn = 0.3;
            tetha = 45;
        }

        public Formulas(double r, double rn, double tetha)
        {
            this.r = r; 
            this.rn = rn; 

            if (tetha < 0)
            {
                DialogResult dialog = MessageBox.Show(
                    "Недопустимое значение угла! Значение установлено на 45 градусов.", 
                    "Предупреждение", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                this.tetha = 45 * PI / 180;
            }
            else
            {
                this.tetha = tetha * PI / 180; 
            }
        }

        internal void CalculateValues(double iteration, double eps)
        {
            Alpha = iteration * PI / 180;
            cyn = CountCyn(eps);
            cx = CountCx(eps);
            mzn = CountMzn(eps);
            mzc = CountMzc(eps);
            xD = CountXD(eps);
        }

        internal double CountBeta()
        {
            return Math.Asin(Math.Tan(Tetha) / Math.Tan(Alpha));
        }

        internal double CountGamma()
        {
            return Math.Acos(Math.Sin(Tetha) / Math.Sin(Alpha));
        }

        internal double CountA()
        {
            return Math.Sqrt(Math.Pow(Math.Sin(Alpha), 2) - Math.Pow(Math.Sin(Tetha), 2));
        }

        //
        // counting aerodynamic params for a truncated cone
        //

        internal double CountCynS(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 0.5 * Math.Pow(Math.Cos(Tetha), 4) * Math.Sin(2 * Alpha);
            }
            // Tetha < Alpha <= PI/2
            else
            {
                return 0.25 * Math.Pow(Math.Cos(Tetha), 4) * Math.Sin(2 * Alpha) * (1 + 2 * CountBeta() / PI)
                        + CountGamma() * Math.Sin(Alpha) / PI + (1 / (3 * PI)) * Math.Sin(Alpha) * Math.Sin(Tetha)
                        * (Math.Pow(Math.Sin(Tetha), 2) * (3 - Math.Pow(Math.Sin(Alpha), -2)) - 5) * CountA();
            }
        }

        internal double CountCxS(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 2 * Math.Pow(Math.Cos(Tetha), 2) * (1 - 0.5 * Math.Pow(Math.Cos(Tetha), 2)
                       - (1 - 0.75 * Math.Pow(Math.Cos(Tetha), 2)) * Math.Pow(Math.Sin(Alpha), 2));
            }
            // Tetha < Alpha <= PI/2
            else
            {
                return (1 + 2 * CountBeta() / PI) * (1 - 0.5 * Math.Pow(Math.Cos(Tetha), 2)
                       - (1 - 0.75 * Math.Pow(Math.Cos(Tetha), 2)) * Math.Pow(Math.Sin(Alpha), 2))
                       * Math.Pow(Math.Cos(Tetha), 2) + CountGamma() * Math.Cos(Alpha) / PI
                       + (Math.Cos(Alpha) / (2 * PI)) * Math.Sin(Tetha)
                       * (1 - 3 * Math.Pow(Math.Sin(Tetha), 2)) * CountA();
            }
        }

        internal double CountCynC(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 0.5 * Math.Pow(Math.Cos(Tetha), 2) * Math.Sin(2 * Alpha);
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double tangens = Math.Tan(Tetha) / Math.Tan(Alpha);
                return 0.5 * Math.Pow(Math.Cos(Tetha), 2) * Math.Sin(2 * Alpha)
                        * (1 + 2 * CountBeta() / PI + (2 / (3 * PI)) * Math.Sqrt(1 - Math.Pow(tangens, 2)) 
                        * (2 * Math.Pow(tangens, -1) + tangens));
            }
        }

        internal double CountCxC(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 2 * Math.Pow(Math.Sin(Tetha), 2) + (1 - 3 * Math.Pow(Math.Sin(Tetha), 2))
                        * Math.Pow(Math.Sin(Alpha), 2);
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double tangens = Math.Tan(Tetha) / Math.Tan(Alpha);
                return 0.5 * (1 + 2 * CountBeta() / PI)
                        * (2 * Math.Pow(Math.Sin(Tetha), 2) + (1 - 3 * Math.Pow(Math.Sin(Tetha), 2))
                        * Math.Pow(Math.Sin(Alpha), 2)) + (0.75 / PI) * Math.Sqrt(1 - Math.Pow(tangens, 2))
                        * Math.Sin(2 * Alpha) * Math.Sin(2 * Tetha);
            }
        }

        //
        // counting cone with sperical segnent
        //

        internal double CountRn()
        {
            return Rn / R;
        }

        internal double CountCyn(double eps)
        {
            return CountCynS(eps) * Math.Pow(CountRn(), 2) + CountCynC(eps) * (1 - Math.Pow(CountRn() * Math.Cos(Tetha), 2));
        }

        internal double CountCx(double eps)
        {
            return -CountCxS(eps) * Math.Pow(CountRn(), 2) - CountCxC(eps) * (1 - Math.Pow(CountRn() * Math.Cos(Tetha), 2));
        }



        // capsule length
        internal double CountL()
        {
            return R / Math.Tan(Tetha) + Rn - Rn / Math.Sin(Tetha);
        }

        // truncated cone length
        internal double CountLc()
        {
            return (R - Rn * Math.Cos(Tetha)) * (1.0 / Math.Tan(Tetha));
        }

        internal double CountL0()
        {
            return CountL() / R * Math.Tan(Tetha);
        }

        internal double CountRL()
        {
            return Rn / R * Math.Cos(Tetha);
        }

        // value interpretates the center of truncated cone
        internal double CountXd()
        {
            double RL = CountRL();
            return 2 / (3 * Math.Pow(Math.Cos(Tetha), 2)) *
            ((1 + RL + RL * RL) / (1 - RL * RL)) - RL / (1 - RL);
        }

        internal double CountMzn(double eps)
        {
            return -CountCynS(eps) * Math.Tan(Tetha) / CountL0() * Math.Pow(CountRn(), 3)
                    - CountCynC(eps) / CountL0() * (1 - Math.Pow(CountRn() * Math.Cos(Tetha), 2))
                    * (CountXd() * CountLc() / CountL() + (1 - CountLc() / CountL()));
        }

        // !!!!! I have question!!!! 
        double xC = -1;
        //

        internal double CountMzc(double eps)
        {
            return CountMzn(eps) - CountCyn(eps) * xC;
        }

        internal double CountXD(double eps)
        {
            return CountMzn(eps) / CountCyn(eps);
        }

    }
}
