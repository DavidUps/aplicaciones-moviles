using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    { 
            static void Main(string[] args)
        {
            Fecha f1 = new Fecha(30,11,2004),
                  f2 = new Fecha(12,1,2017),
                  f3 = new Fecha(5, 6, 2008),
                  f4 = new Fecha(1, 1, 1);

            int Swithc = 0;
            do
            {

                Console.Clear();

                Console.WriteLine("1.- Fecha se corresponde a un año bisiesto. \n" + 
                                  "2.- Aumentar en el mes en 1 y cambar de año si es 12 + 1. \n" +
                                  "3.- Devolver el numero de dias desde el 1 de enero del año en curso \n" + 
                                  "4.- Imprime la mayor de todas las fechas.\n" + 
                                  "5.- Salir");

                Swithc = Int32.Parse(Console.ReadLine());
                switch (Swithc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1.- Fecha se corresponde a un año bisiesto.");
                        if (f1.Anio() % 4 == 0)
                        {
                            Console.WriteLine("Es bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("No lo es");
                        }

                        if (f2.Anio() % 4 == 0)
                        {
                            Console.WriteLine("Es bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("No lo es");
                        }

                        if (f3.Anio() % 4 == 0)
                        {
                            Console.WriteLine("Es bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("No lo es");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2.- Aumentar en el mes en 1 y cambar de año si es 12 + 1.");
                        f1.sumMes();
                        f2.sumMes();
                        f3.sumMes();
                        f1.imprimirFechas();
                        f2.imprimirFechas();
                        f3.imprimirFechas();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("3.- Devolver el numero de dias desde el 1 de enero del año en curso");
                        int totalF1 = 0,
                            totalF2 = 0,
                            totalF3 = 0;

                        do
                        {
                            if (f1.Mes() == 2)
                            {
                                f1.sumMes();
                                totalF1 = totalF1 + 27;
                            }
                            if (f1.Mes() % 2 != 0)
                            {
                                f1.sumMes();
                                totalF1 = totalF1 + 30;
                            }
                            if (f1.Mes() % 2 == 0)
                            {
                                f1.sumMes();
                                totalF1 = totalF1 + 31;
                            }
                        } while (f4.Dia() != f1.Dia() && f4.Mes() != f1.Mes());

                        do
                        {
                            if (f2.Mes() == 2)
                            {
                                f2.sumMes();
                                totalF2 = totalF2 + 27;
                            }
                            if (f2.Mes() % 2 != 0)
                            {
                                f2.sumMes();
                                totalF2 = totalF2 + 30;
                            }
                            if (f2.Mes() % 2 == 0)
                            {
                                f2.sumMes();
                                totalF2 = totalF2 + 31;
                            }
                        } while (f4.Dia() != f2.Dia() && f4.Mes() != f2.Mes());

                        do
                        {
                            if (f3.Mes() == 2)
                            {
                                f3.sumMes();
                                totalF3 = totalF3 + 27;
                            }
                            if (f3.Mes() % 2 != 0)
                            {
                                f3.sumMes();
                                totalF3 = totalF3 + 30;
                            }
                            if (f3.Mes() % 2 == 0)
                            {
                                f3.sumMes();
                                totalF3 = totalF3 + 31;
                            }
                        } while (f4.Dia() != f3.Dia() && f4.Mes() != f3.Mes());

                        Console.Write("total de dias F1: " + totalF1 + "\n");
                        Console.Write("total de dias F2: " + totalF2 + "\n");
                        Console.Write("total de dias f3: " + totalF3 + "\n");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4.- Imprime la mayor de todas las fechas");
                        f1.imprimirFechas();
                        f2.imprimirFechas();
                        f3.imprimirFechas();
                        Console.ReadKey();
                        break;
                }
            } while (Swithc != 5);
        }
    }
}
