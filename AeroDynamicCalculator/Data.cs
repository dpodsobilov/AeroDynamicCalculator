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
        Dictionary<int, double> dictCxv;
        Dictionary<int, double> dictCyv;
        Dictionary<int, double> dictCyvDer;


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
            set
            {
                dictXD = value;
            }
        }

        public Dictionary<int, double> DictCxv
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

        public Dictionary<int, double> DictCyv
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

        public Dictionary<int, double> DictCyvDer
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
            dictCx = new Dictionary<int, double>();
            dictCyn = new Dictionary<int, double>();
            dictMzn = new Dictionary<int, double>();
            dictMzc = new Dictionary<int, double>();
            dictXD = new Dictionary<int, double>();
            dictCxv = new Dictionary<int, double>();
            dictCyv = new Dictionary<int, double>();
            dictCyvDer = new Dictionary<int, double>();
        }
    }
}
