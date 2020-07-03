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
        //public int _m
        //{
        //    get { return _m; }
        //    set { _m = value; }
        //}

        private int n;
        //public int _n
        //{
        //    get { return _n; }
        //    set { _n = value; }
        //}



        public cMatriz(int e, int e1)
        {
            m = e;
            n = e1;
        }

        public void CrearMatriz()
        {
            matriz = new cPixel[(int)n,(int) m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[j, i] = new cPixel(j, i, "O");
                }
            }
        }

        public void LimpiarMatriz()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[j, i] = new cPixel(j, i, "O");
                }
            }
        }

        public void funcionH(int c1, int c2, int c3, string color)
        {
            for (int j = c1; j < c2; j++)
            {
                matriz[j, c3 - 1].color = color;
            }
        }

        public void funcionV(int c1, int c2, int c3, string color)
        {
            for (int j = c1; j < c2; j++)
            {
                matriz[c3, j].color = color;
            }
        }

        public void funcionF(int k1 , int j1, string color)
        {
            string colorBase = matriz[k1, j1].color;
            matriz[k1,j1].color = color;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[j, i].color == colorBase)
                        matriz[j, i] = new cPixel(j, i, color);
                }
            }
        }

        public void funcionL(int k, int j, string color)
        {
            matriz[k,j].color = color;
        }

        public void Imprimir()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(
                    matriz[j, i].color);
                }
                Console.WriteLine("");
            }
        }
    }
}
