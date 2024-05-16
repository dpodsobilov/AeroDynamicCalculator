using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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

        /// <summary
        /// константы внутри одной итерации
        /// cscAlpha - косеканс
        /// </summary>
        double sinAlpha, cosAlpha, tanAlpha, sin2Alpha, beta, gamma, A, cos2Alpha, cscAlpha, secAlpha;

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
            tetha = 45 * PI / 180;
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

            CountConstantsOnIteraion();

            cyn = CountCyn(eps);
            cx = CountCx(eps);
            mzn = CountMzn(eps);
            mzc = CountMzc(eps);
            xD = CountXD(eps);
            cxv = CountCxv();
            cyv = CountCyv();

            cyvDerivative = CountCyvDerivative(eps);

            /* if (!double.IsNaN(cyv))
             {
                 cyvDerivative = CountCyvDerivative(eps);

             }*/


            data.DictCx.Add(iteration, cx);
            data.DictCyn.Add(iteration, cyn);
            data.DictMzn.Add(iteration, mzn);
            data.DictMzc.Add(iteration, mzc);
            data.DictXD.Add(iteration, xD);
            data.DictCxv.Add(iteration, cxv);
            data.DictCyv.Add(iteration, cyv);
            data.DictCyvDer.Add(iteration, cyvDerivative);

            return data;
        }

        internal void CountConstantsOnIteraion() {
            sinAlpha = Math.Sin(Alpha);
            cosAlpha = Math.Cos(Alpha);
            tanAlpha = Math.Tan(Alpha);
            sin2Alpha = Math.Sin(2 * Alpha);
            cos2Alpha = Math.Cos(2 * Alpha);

            cscAlpha = 1 / sinAlpha;
            secAlpha = 1 / cosAlpha;


            beta = CountBeta();
            gamma = CountGamma();
            A = CountA();
        }

        internal double CountBeta()
        {
            return Math.Asin(tanTetha / tanAlpha);
        }

        internal double CountGamma()
        {
            return Math.Acos(sinTetha / sinAlpha);
        }

        internal double CountA()
        {
            return Math.Sqrt(Math.Pow(sinAlpha, 2) - Math.Pow(sinTetha, 2));
        }

        //
        // counting aerodynamic params for a truncated cone
        //

        internal double CountCynS(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 0.5 * Math.Pow(cosTetha, 4) * sin2Alpha;
            }
            // Tetha < Alpha <= PI/2
            else
            {
                return 0.25 * Math.Pow(cosTetha, 4) * sin2Alpha * (1 + 2 * beta / PI)
                        + gamma * sinAlpha / PI + (1 / (3 * PI)) * sinAlpha * sinTetha
                        * (Math.Pow(sinTetha, 2) * (3 - Math.Pow(sinAlpha, -2)) - 5) * A;
            }
        }

        internal double CountCxS(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 2 * Math.Pow(cosTetha, 2) * (1 - 0.5 * Math.Pow(cosTetha, 2)
                       - (1 - 0.75 * Math.Pow(cosTetha, 2)) * Math.Pow(sinAlpha, 2));
            }
            // Tetha < Alpha <= PI/2
            else
            {
                return (1 + 2 * beta / PI) * (1 - 0.5 * Math.Pow(cosTetha, 2)
                       - (1 - 0.75 * Math.Pow(cosTetha, 2)) * Math.Pow(sinAlpha, 2))
                       * Math.Pow(cosTetha, 2) + gamma * cosAlpha / PI
                       + (cosAlpha / (2 * PI)) * sinTetha
                       * (1 - 3 * Math.Pow(sinTetha, 2)) * A;
            }
        }

        internal double CountCynC(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return Math.Pow(cosTetha, 2) * sin2Alpha;
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double tangens = tanTetha / tanAlpha;
                return 0.5 * Math.Pow(cosTetha, 2) * sin2Alpha
                        * (1 + 2 * beta / PI + (2 / (3 * PI)) * Math.Sqrt(1 - Math.Pow(tangens, 2)) 
                        * (2 * Math.Pow(tangens, -1) + tangens));
            }
        }

        internal double CountCxC(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 2 * Math.Pow(sinTetha, 2) + (1 - 3 * Math.Pow(sinTetha, 2))
                        * Math.Pow(sinAlpha, 2);
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double tangens = tanTetha / tanAlpha;
                return 0.5 * (1 + 2 * beta / PI)
                        * (2 * Math.Pow(sinTetha, 2) + (1 - 3 * Math.Pow(sinTetha, 2))
                        * Math.Pow(sinAlpha, 2)) + (1.5 / PI) * Math.Sqrt(1 - Math.Pow(tangens, 2))
                        * sin2Alpha * sin2Tetha;
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
            return CountCynS(eps) * Math.Pow(rnDash, 2) + CountCynC(eps) * (1 - Math.Pow(rnDash * cosTetha, 2));
        }

        internal double CountCx(double eps)
        {
            return -CountCxS(eps) * Math.Pow(rnDash, 2) - CountCxC(eps) * (1 - Math.Pow(rnDash * cosTetha, 2));
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
            return (Cx * cosAlpha - Cyn * sinAlpha);
        }

        internal double CountCyv()
        {
            return (Cyn * cosAlpha + Cx * sinAlpha);
        }


        #region Derivatives

        internal double CountCyvDerivative(double eps) {
            cxCDerivative = CountCxCDerivative(eps);
            cxSDerivative = CountCxSDerivative(eps);
            cxDerivative = CountCxDerivative();

            cynCDerivative = CountCynCDerivative(eps);
            cynSDerivative = CountCynSDerivative(eps);
            cynDerivative = CountCynDerivative();

            return (cynDerivative * cosAlpha - cyn * sinAlpha + cxDerivative * sinAlpha + cx * cosAlpha);
        }

        internal double CountCynDerivative() {
            return (cynSDerivative * Math.Pow(rnDash, 2) + cynCDerivative * (1 - Math.Pow(rnDash * cosTetha, 2)));
        }

        internal double CountCynSDerivative(double eps) {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return (Math.Pow(cosTetha, 4) * cos2Alpha);
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double first = 0.5 * cos2Alpha * Math.Pow(cosTetha, 4) * (1 + 2 / PI * beta);
                double second = (sin2Alpha * sinTetha * Math.Pow(cosTetha, 3)) 
                                / (2 * PI * Math.Pow(sinAlpha, 2) * Math.Sqrt(1 - Math.Pow(tanTetha / tanAlpha, 2)));
                double third = cosAlpha / PI * gamma;
                double fourth = sinTetha / (PI * tanAlpha * Math.Sqrt(1 - Math.Pow(sinTetha / sinAlpha, 2)));
                double fifth = (cosAlpha * (- Math.Pow(cscAlpha, 2) - 2) * Math.Pow(sinTetha, 3) * A) / (3 * PI);
                double sixth = (Math.Pow(sinAlpha, 2) * cosAlpha * (-Math.Pow(cscAlpha, 2) - 2) * Math.Pow(sinTetha, 3)) / (3 * PI * A);
                double seventh = (2 * (1 / tanAlpha) * cscAlpha * Math.Pow(sinTetha, 3) * A) / (3 * PI);

                // вычитаем second
                return first - second + third + fourth + fifth + sixth + seventh;
            }
        }

        internal double CountCynCDerivative(double eps) {
            double cos2ACosT2 = Math.Pow(cosTetha, 2) * cos2Alpha;
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 2 * cos2ACosT2;
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double sqrtTangens = Math.Sqrt(1 - Math.Pow(tanTetha / tanAlpha, 2));
                double tanAcotTcotAtanT = (2 * tanAlpha * (1 / tanTetha) + (1 / tanAlpha) * tanTetha);

                double first = (2 * tanAcotTcotAtanT * sqrtTangens) / (3 * PI);
                double second = (2 * beta) / PI + 1;

                double secMul = 0.5 * sin2Alpha * Math.Pow(cosTetha, 2);
                double third = - (Math.Pow(cscAlpha, 2) * tanTetha) / (PI * sqrtTangens);
                double fourth = (2 * (1 / tanAlpha) * Math.Pow(cscAlpha * tanTetha, 2) * tanAcotTcotAtanT) / (3 * PI * sqrtTangens);
                double fifth = (2 * sqrtTangens * (2 * Math.Pow(secAlpha, 2) * (1 / tanTetha) - Math.Pow(cscAlpha, 2) * tanTetha)) / (3 * PI);

                return cos2ACosT2 * (first + second) + secMul * (third + fourth + fifth);
            }
        }

        internal double CountCxDerivative() {
            return (- cxSDerivative * Math.Pow(rnDash, 2) - cxCDerivative * (1 - Math.Pow(rnDash * cosTetha, 2)));
        }

        internal double CountCxSDerivative(double eps)
        {
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return (sinAlpha * cosAlpha * Math.Pow(cosTetha, 2) * (3 * Math.Pow(cosTetha, 2) - 4));
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double first = (-2 * sinAlpha * cosAlpha * (1 - 3 * Math.Pow(cosTetha, 2) / 4) * Math.Pow(cosTetha, 2) * (2 * beta / PI + 1));
                double second = (2 * Math.Pow(cscAlpha, 2) * sinTetha * cosTetha * (-Math.Pow(sinAlpha, 2) * (1 - 3 * Math.Pow(cosTetha, 2) / 4) - 0.5 * Math.Pow(cosTetha, 2) + 1))
                    / (PI * Math.Sqrt(1 - Math.Pow(tanTetha / tanAlpha, 2)));
                double third = (Math.Pow((1 / tanAlpha), 2) * sinTetha) / (PI * Math.Sqrt(1 - Math.Pow(cscAlpha * sinTetha, 2)));
                double fourth = (sinAlpha * gamma) / PI;
                double fifth = (sinAlpha * sinTetha * (3 * Math.Pow(sinTetha, 2) - 1) * (Math.Pow(sinAlpha, 2) - Math.Pow(cosAlpha, 2) - Math.Pow(sinTetha, 2))) / (2 * PI * A);

                // отнимаем second и fourth
                return first - second + third - fourth + fifth;
            }

        }

        internal double CountCxCDerivative(double eps) {
            double sinAcosA3sinT2 = sinAlpha * cosAlpha * (1 - 3 * Math.Pow(sinTetha, 2));
            // 0 <= Alpha <= Tetha
            if (Alpha >= eps && Alpha <= Tetha)
            {
                return 2 * sinAcosA3sinT2;
            }
            // Tetha < Alpha <= PI/2
            else
            {
                double sqrtTangens = Math.Sqrt(1 - Math.Pow(tanTetha / tanAlpha, 2));

                double first = 2 * beta / PI + 1 ;
                double second = 2 * (Math.Pow(cscAlpha, 2) * tanTetha * (Math.Pow(sinAlpha, 2) * (1 - 3 * Math.Pow(sinTetha, 2)) + 2 * Math.Pow(sinTetha, 2) )) / (PI * sqrtTangens);
                double third = (3 * cos2Alpha * sin2Tetha * sqrtTangens) / PI;
                double fourth = (3 * sin2Alpha * (1 / tanAlpha) * Math.Pow(cscAlpha, 2) * sin2Tetha * Math.Pow(tanTetha, 2)) / (2 * PI * sqrtTangens);

                // вычитаем second
                return 0.5 * (sinAcosA3sinT2 * first - second + third + fourth); 
            }
        }

        #endregion
    }
}
