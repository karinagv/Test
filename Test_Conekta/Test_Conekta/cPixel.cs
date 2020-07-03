using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Conekta
{
    class cPixel
    {
        public cPixel(int i, int j, string col)
        {
            _M = i;
            _N = j;
            _color = col;
        }
        private int _M;
        public int M
        {
            get { return _M; }
            set { _M = value; }
        }

        private int _N;
        public int N
        {
            get { return _N; }
            set { _N = value; }
        }

        private string _color;
        public string color
        {
            get { return _color; }
            set { _color = value; }
        }

    }
}
