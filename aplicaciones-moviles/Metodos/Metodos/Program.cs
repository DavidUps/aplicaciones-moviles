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
                  f2 = new Fecha(12,1,2007),
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
                        f1.Anio();
                        f2.Anio();
                        f3.Anio();
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2.- Aumentar en el mes en 1 y cambar de año si es 12 + 1.");
                        f1.sumMes();
                        f2.sumMes();
                        f3.sumMes();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("3.- Devolver el numero de dias desde el 1 de enero del año en curso");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4.- Imprime la mayor de todas las fechas");
                        if (f1.esMayor(f2) && f1.esMayor(f3) && f1.esMayor(f4))
                        {
                            Console.WriteLine(f1.Imprimir());
                        }
                        else if ((f2.esMayor(f3) && f2.esMayor(f4)))
                        {
                            Console.WriteLine(f2.Imprimir());
                        }
                        else if (f3.esMayor(f4))
                        {
                            Console.WriteLine(f3.Imprimir());
                        }
                        else
                            Console.WriteLine(f4.Imprimir());
                        Console.ReadKey();
                        break;
                }
            } while (Swithc != 5);
        }
    }
}
