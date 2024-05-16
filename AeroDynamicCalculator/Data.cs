using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroDynamicCalculator
{
    internal class Data
    {
        Dictionary<double, double> dictCx;
        Dictionary<double, double> dictCyn;
        Dictionary<double, double> dictMzn;
        Dictionary<double, double> dictMzc;
        Dictionary<double, double> dictXD;
        Dictionary<double, double> dictCxv;
        Dictionary<double, double> dictCyv;
        Dictionary<double, double> dictCyvDer;


        public Dictionary<double, double> DictCx
        {
            get
            {
                return dictCx;
            }
            set
            {
                dictCx = value;
            }
        }

        public Dictionary<double, double> DictCyn
        {
            get
            {
                return dictCyn;
            }
            set
            {
                dictCyn = value;
            }
        }

        public Dictionary<double, double> DictMzn
        {
            get
            {
                return dictMzn;
            }
            set
            {
                dictMzn = value;
            }
        }

        public Dictionary<double, double> DictMzc
        {
            get
            {
                return dictMzc;
            }
            set
            {
                dictMzc = value;
            }
        }

        public Dictionary<double, double> DictXD
        {
            get
            {
                return dictXD;
            }
            set
            {
                dictXD = value;
            }
        }

        public Dictionary<double, double> DictCxv
        {
            get
            {
                return dictCxv;
            }
            set
            {
                dictCxv = value;
            }
        }

        public Dictionary<double, double> DictCyv
        {
            get
            {
                return dictCyv;
            }
            set
            {
                dictCyv = value;
            }
        }

        public Dictionary<double, double> DictCyvDer
        {
            get
            {
                return dictCyvDer;
            }
            set
            {
                dictCyvDer = value;
            }
        }

        public Data()
        {
            dictCx = new Dictionary<double, double>();
            dictCyn = new Dictionary<double, double>();
            dictMzn = new Dictionary<double, double>();
            dictMzc = new Dictionary<double, double>();
            dictXD = new Dictionary<double, double>();
            dictCxv = new Dictionary<double, double>();
            dictCyv = new Dictionary<double, double>();
            dictCyvDer = new Dictionary<double, double>();
        }
    }
}
