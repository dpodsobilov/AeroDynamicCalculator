using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroDynamicCalculator
{
    internal class Data
    {
        Dictionary<int, double> dictCx;
        Dictionary<int, double> dictCyn;
        Dictionary<int, double> dictMzn;
        Dictionary<int, double> dictMzc;
        Dictionary<int, double> dictXD;

        public Dictionary<int, double> DictCx
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

        public Dictionary<int, double> DictCyn
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

        public Dictionary<int, double> DictMzn
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

        public Dictionary<int, double> DictMzc
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

        public Dictionary<int, double> DictXD
        {
            get
            {
                return dictXD;
            }
        }

        public Data()
        {
            dictCx = new Dictionary<int, double>();
            dictCyn = new Dictionary<int, double>();
            dictMzn = new Dictionary<int, double>();
            dictMzc = new Dictionary<int, double>();
            dictXD = new Dictionary<int, double>();
        }
    }
}
