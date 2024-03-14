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
        /// <summary>
        /// cxv - коэффициент лобового сопротивнления
        /// cyv - коэффициент подъемной силы
        /// </summary>
        double cxv, cyv;
        double cyvDerivative, cynDerivative, cxDerivative, cynSDerivative, cynCDerivative, cxSDerivative, cxCDerivative;

        // константы с тетта
        double sinTetha, cosTetha, tanTetha, sin2Tetha, rnDash, l0, l, lc, xd, rl;

        // константы внутри одной итерации


        Data data;

        #region getters, setters

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
        public double Cxv
        {
            get
            {
                return cxv;
            }
        }
        public double Cyv
        {
            get
            {
                return Cyv;
            }
        }
        public double CyvDerivative
        {
            get
            {
                return cyvDerivative;
            }
        }

        #endregion

        public Formulas()
        {
            r = 0.4;
            rn = 0.3;
            tetha = 45;
        }

        public Formulas(double r, double rn, double tetha)
        {
            data = new Data();
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
                this.tetha = (tetha % 360) * PI / 180; 
            }

            // рассчет констант с Tetha
            CountTethaConstants();
        }

        internal void CountTethaConstants() {
            sinTetha = Math.Sin(Tetha);
            sin2Tetha = Math.Sin(2 * Tetha);
            cosTetha = Math.Cos(Tetha);
            tanTetha = Math.Tan(Tetha);

            // другие константы с тетта
            // rnDash, l0, l, lc, xd, rl;
            rnDash = CountRn();
            l = CountL();
            l0 = CountL0();
            lc = CountLc();
            xd = CountXd();
            rl = CountRL();
        }

        internal Data CalculateValues(int iteration, double eps)
        {
            Alpha = iteration * PI / 180.0;

            //CountConstantsOnIteraion();

            cyn = CountCyn(eps);
            cx = CountCx(eps);
            mzn = CountMzn(eps);
            mzc = CountMzc(eps);
            xD = CountXD(eps);
            cxv = CountCxv();
            cyv = CountCyv();

            #region Вычисления производных
            /*rn = CountRn();

            cxCDerivative = CountCxCDerivative(eps);
            cxSDerivative = CountCxSDerivative(eps);
            cxDerivative = CountCxDerivative();

            cynCDerivative = CountCynCDerivative(eps);
            cynSDerivative = CountCynSDerivative(eps);
            cynDerivative = CountCynDerivative();

            cyvDerivative = CountCyvDerivative();*/

            #endregion

            data.DictCx.Add(iteration, cx);
            data.DictCyn.Add(iteration, cyn);
            data.DictMzn.Add(iteration, mzn);
            data.DictMzc.Add(iteration, mzc);
            data.DictXD.Add(iteration, xD);
            data.DictCxv.Add(iteration, cxv);
            data.DictCyv.Add(iteration, cyv);

            return data;
        }

        internal void CountConstantsOnIteraion() {
            
        }

        internal double CountBeta()
        {
            return Math.Asin(tanTetha / Math.Tan(Alpha));
        }

        internal double CountGamma()
        {
            return Math.Acos(sinTetha / Math.Sin(Alpha));
        }

        internal double CountA()
        {
            return Math.Sqrt(Math.Pow(Math.Sin(Alpha), 2) - Math.Pow(sinTetha, 2));
        }

        //
        // counting aerodynamic params for a truncated cone
        //

        internal double CountCynS(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 0.5 * Math.Pow(cosTetha, 4) * Math.Sin(2 * Alpha);
            }
            // Tetha < Alpha <= PI/2
            else
            {
                return 0.25 * Math.Pow(cosTetha, 4) * Math.Sin(2 * Alpha) * (1 + 2 * CountBeta() / PI)
                        + CountGamma() * Math.Sin(Alpha) / PI + (1 / (3 * PI)) * Math.Sin(Alpha) * sinTetha
                        * (Math.Pow(sinTetha, 2) * (3 - Math.Pow(Math.Sin(Alpha), -2)) - 5) * CountA();
            }
        }

        internal double CountCxS(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 2 * Math.Pow(cosTetha, 2) * (1 - 0.5 * Math.Pow(cosTetha, 2)
                       - (1 - 0.75 * Math.Pow(cosTetha, 2)) * Math.Pow(Math.Sin(Alpha), 2));
            }
            // Tetha < Alpha <= PI/2
            else
            {
                return (1 + 2 * CountBeta() / PI) * (1 - 0.5 * Math.Pow(cosTetha, 2)
                       - (1 - 0.75 * Math.Pow(cosTetha, 2)) * Math.Pow(Math.Sin(Alpha), 2))
                       * Math.Pow(cosTetha, 2) + CountGamma() * Math.Cos(Alpha) / PI
                       + (Math.Cos(Alpha) / (2 * PI)) * sinTetha
                       * (1 - 3 * Math.Pow(sinTetha, 2)) * CountA();
            }
        }

        internal double CountCynC(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 0.5 * Math.Pow(cosTetha, 2) * Math.Sin(2 * Alpha);
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double tangens = tanTetha / Math.Tan(Alpha);
                return 0.5 * Math.Pow(cosTetha, 2) * Math.Sin(2 * Alpha)
                        * (1 + 2 * CountBeta() / PI + (2 / (3 * PI)) * Math.Sqrt(1 - Math.Pow(tangens, 2)) 
                        * (2 * Math.Pow(tangens, -1) + tangens));
            }
        }

        internal double CountCxC(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 2 * Math.Pow(sinTetha, 2) + (1 - 3 * Math.Pow(sinTetha, 2))
                        * Math.Pow(Math.Sin(Alpha), 2);
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double tangens = tanTetha / Math.Tan(Alpha);
                return 0.5 * (1 + 2 * CountBeta() / PI)
                        * (2 * Math.Pow(sinTetha, 2) + (1 - 3 * Math.Pow(sinTetha, 2))
                        * Math.Pow(Math.Sin(Alpha), 2)) + (0.75 / PI) * Math.Sqrt(1 - Math.Pow(tangens, 2))
                        * Math.Sin(2 * Alpha) * sin2Tetha;
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
            return CountCynS(eps) * Math.Pow(CountRn(), 2) + CountCynC(eps) * (1 - Math.Pow(CountRn() * cosTetha, 2));
        }

        internal double CountCx(double eps)
        {
            return -CountCxS(eps) * Math.Pow(CountRn(), 2) - CountCxC(eps) * (1 - Math.Pow(CountRn() * cosTetha, 2));
        }



        // capsule length
        internal double CountL()
        {
            return R / tanTetha + Rn - Rn / sinTetha;
        }

        // truncated cone length
        internal double CountLc()
        {
            return (R - Rn * cosTetha) * (1.0 / tanTetha);
        }

        internal double CountL0()
        {
            return l / R * tanTetha;
        }

        internal double CountRL()
        {
            return Rn / R * cosTetha;
        }

        // value interpretates the center of truncated cone
        internal double CountXd()
        {;
            return 2 / (3 * Math.Pow(cosTetha, 2)) *
            ((1 + rl + rl * rl) / (1 - rl * rl)) - rl / (1 - rl);
        }

        internal double CountMzn(double eps)
        {
            return -CountCynS(eps) * tanTetha / l0 * Math.Pow(rnDash, 3)
                    - CountCynC(eps) / l0 * (1 - Math.Pow(rnDash * cosTetha, 2))
                    * (xd * lc / l + (1 - lc / l));
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

        internal double CountCxv()
        {
            return (Cx * Math.Cos(Alpha) - Cyn * Math.Sin(Alpha));
        }

        internal double CountCyv()
        {
            return (Cyn * Math.Cos(Alpha) + Cx * Math.Sin(Alpha));
        }


        #region Derivatives
        /*double cyvDerivative, cynDerivative, cxDerivative, cynSDerivative, cynCDerivative, cxSDerivative, cxCDerivative;*/

        internal double CountCyvDerivative() { 
            return (cynDerivative * Math.Cos(Alpha) - cyn * Math.Sin(Alpha) + cxDerivative * Math.Sin(Alpha) + cx * Math.Cos(Alpha));
        }

        internal double CountCynDerivative() {
            return (cynSDerivative * Math.Pow(rn, 2) + cynCDerivative * (1 - Math.Pow(rn, 2) * cosTetha));
        }

        internal double CountCxDerivative() { return 0; }

        internal double CountCynSDerivative(double eps) { return 0; }

        internal double CountCynCDerivative(double eps) { return 0; }

        internal double CountCxSDerivative(double eps) { return 0; }

        internal double CountCxCDerivative(double eps) { return 0; }

        #endregion
    }
}
