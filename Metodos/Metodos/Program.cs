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
                  f2 = new Fecha(12,2,2017),
                  f3 = new Fecha(5, 6, 2008);

            int Swithc = 0;
            do
            {

                Console.Clear();
                Console.WriteLine("1.- Fecha se corresponde a un año bisiesto. \n" + "2.- Aumentar en el mes en 1 y cambar de año si es 12 + 1. \n" + "3.- Devolver el numero de dias desde el 1 de enero del año en curso \n" + "4.- Crear 3 fechas y leer los valores de las fechas por pantalla. Imprime la mayor de todas las fechas.\n" + "5.- Salir");
                Swithc = Int32.Parse(Console.ReadLine());
                switch (Swithc)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            } while (Swithc != 5);
        }
    }
}
