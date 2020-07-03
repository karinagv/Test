using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_Conekta
{
    class Program
    {
        public static bool bFin = false;
        public static bool bImageCreate = false;
        public static bool bError = false;
        public static cMatriz matriz ;

        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^\d+$");
            Console.WriteLine("Bienvenido");
            while (!bFin)
            {
                Console.WriteLine("Escribe el comando que deseas ejecutar");
                string res = Console.ReadLine();
                if (res == "X")
                {
                    bFin = true;
                }
                string[] command = res.Split(' ');
                switch (command[0].ToUpper())
                {
                    case "I":
                        bImageCreate = true;
                        if (command.Length == 3)
                        {
                            if (regex.IsMatch(command[1]))
                            {
                                if (regex.IsMatch(command[2]))
                                {
                                    if (Convert.ToInt32(command[1]) > 0 && Convert.ToInt32(command[2]) > 0 && Convert.ToInt32(command[2]) < 251 && Convert.ToInt32(command[1]) < 251)
                                        matriz = new cMatriz(Convert.ToInt32(command[1]), Convert.ToInt32(command[2]));
                                    else
                                        bError = true;
                                }
                                else
                                {
                                    bError = true;
                                }
                            }
                            else
                            {
                                bError = true;
                            }
                           
                            if (!bError)
                            {

                                bImageCreate = true;
                                matriz.CrearMatriz();
                                //matriz.Imprimir();
                            }
                        }
                        else
                        {
                            bError = true;
                        }   
                        break;
                    case "C":
                        if (command.Length > 1 || !bImageCreate)
                        {
                            bError = true;
                        }
                        else
                        {
                            matriz.LimpiarMatriz();
                            //matriz.Imprimir();
                        }
                        break;
                    case "L":
                        if (command.Length == 4 && bImageCreate && regex.IsMatch(command[1]) && regex.IsMatch(command[2]))
                        {
                            if (Convert.ToInt32(command[1]) > 0 && Convert.ToInt32(command[2]) > 0
                                && Convert.ToInt32(command[2]) <= matriz.n && Convert.ToInt32(command[1]) <= matriz.m)
                            {
                                matriz.funcionL(Convert.ToInt32(command[2]) - 1, Convert.ToInt32(command[1]) - 1, command[3]);
                              //  matriz.Imprimir();
                            }
                            else
                                bError = true;
                        }
                        else
                        {
                            bError = true;
                        }
                        break;
                    case "F":
                        if (command.Length == 4 && bImageCreate && regex.IsMatch(command[1]) && regex.IsMatch(command[2]))
                        {
                            if (Convert.ToInt32(command[2]) > 0 && Convert.ToInt32(command[1]) > 0 
                                &&  Convert.ToInt32(command[2])<= matriz.n && Convert.ToInt32(command[1]) <= matriz.m)
                            {
                                matriz.funcionF(Convert.ToInt32(command[2]) - 1, Convert.ToInt32(command[1]) - 1, command[3]);
                                //matriz.Imprimir();
                            }
                            else
                                bError = true;
                        }
                        else
                        {
                            bError = true;
                        }
                        break;
                    case "H":
                        if (command.Length == 5 && bImageCreate && regex.IsMatch(command[1]) && regex.IsMatch(command[3]) && regex.IsMatch(command[2]))
                        {
                            if (Convert.ToInt32(command[2]) > 0 
                                && Convert.ToInt32(command[1]) > 0 
                                && Convert.ToInt32(command[3]) > 0 
                                && Convert.ToInt32(command[3]) <= matriz.m
                                && Convert.ToInt32(command[1]) <= matriz.n 
                                && Convert.ToInt32(command[2]) <= matriz.n
                                && Convert.ToInt32(command[2]) >= Convert.ToInt32(command[1])
                                )
                            {
                                matriz.funcionH(Convert.ToInt32(command[1])-1,Convert.ToInt32(command[2]), Convert.ToInt32(command[3]), command[4]);
                                //matriz.Imprimir();
                            }
                            else
                                bError = true;
                        }
                        else
                        {
                            bError = true;
                        }

                        break;
                    case "V":
                        if (command.Length == 5 && bImageCreate && regex.IsMatch(command[1]) && regex.IsMatch(command[3]) && regex.IsMatch(command[2]))
                        {
                            if (Convert.ToInt32(command[2]) > 0
                                && Convert.ToInt32(command[1]) > 0
                                && Convert.ToInt32(command[3]) > 0
                                && Convert.ToInt32(command[3]) <= matriz.m
                                && Convert.ToInt32(command[1]) <= matriz.n
                                && Convert.ToInt32(command[2]) <= matriz.n
                                && Convert.ToInt32(command[3]) >= Convert.ToInt32(command[2])
                                )
                            { 
                                matriz.funcionV(Convert.ToInt32(command[2]) - 1, Convert.ToInt32(command[3]), Convert.ToInt32(command[1]) - 1, command[4]);
                                //matriz.Imprimir();
                            }
                            else
                                bError = true;
                        }
                        else
                        {
                            bError = true;
                        }

                        break;
                    case "S":
                        if (command.Length == 1)
                        {
                            matriz.Imprimir();
                        }
                        else
                            bError = true;
                        break;
                    default:
                        bError = true;
                        break;
                }
                if (bError)
                {
                    Console.WriteLine("Error. Comando No reconocido.");
                    bError = false;
                }
                else
                {
                    Console.WriteLine("Comando ejecutado.");
                }
            }
        }
    }
}
