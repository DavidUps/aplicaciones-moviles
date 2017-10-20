using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabla = { 12, 23, 34, 5 };
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("posicion de la tabla " + i + " es: " + tabla[i]);
            }
            //te ahorras el for.
            foreach(int numero in tabla)
            {
                Console.WriteLine(numero);
            }
            if((3.0 / 7) is System.Int32)
            {
                Console.WriteLine("Es de tipo entero");
            }
            else
            {
                Console.WriteLine("No es de tipo entero");
            }
            Console.ReadKey();
        }
    }
}
