using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Conekta
{
    class cMatriz
    {
        private cPixel[,] matriz;
        public cPixel[,] _matriz
        {
            get { return _matriz; }
            set { _matriz = value; }
        }

        private int m;
        public int _m
        {
            get { return _m; }
            set { _m = value; }
        }

        private int n;
        public int _n
        {
            get { return _n; }
            set { _n = value; }
        }

        private bool bFin;
        public bool _bFin
        {
            get { return _bFin; }
            set { _bFin = value; }
        }


        private bool bImageCreate;
        public bool _bImageCreate
        {
            get { return _bImageCreate; }
            set { _bImageCreate = value; }
        }

        private bool bError;
        public bool _bError
        {
            get { return _bError; }
            set { _bError = value; }
        }

        public cMatriz()
        {
            _m = 0;
            _n = 0;
            bFin = false;
            bImageCreate = false;
            bError = false;
        }
    }
}
