using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "David", "Paco", "Andrés", "Andrea", "Carlos Alberto", "Carlos Miguel" };

            for(int i=0; i<nombres.Length-1;i++)
            {
                for(int j=0; j<(nombres.Length-1)-i; j++)
                {
                    if (nombres[j].CompareTo(nombres[j + 1])>0)
                    {
                        string aux;
                        aux = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = aux;
                    }
                }
            }
            foreach(string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.ReadKey();
        }
    }
}
