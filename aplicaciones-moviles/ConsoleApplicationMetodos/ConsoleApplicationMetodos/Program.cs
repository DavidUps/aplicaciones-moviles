using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMetodos
{
    class Program
    {
        static public int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        static public void SumarRef(int n1, int n2, ref int resultado)
        {
            resultado = n1 + n2;
        }
        static public void SumarOut(int n1, int n2, out int resultado)
        {
            resultado = n1 + n2;
        }
        static void Main(string[] args)
        {
            int num1, num2, resultado = 0;
            Console.WriteLine("Introduce num1: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce num2: ");
            num2 = Int32.Parse(Console.ReadLine());
            //Pasar resultado por valor.
            Console.WriteLine("Resultado= " + Sumar(num1, num2));
            //Pasar resultado por referencia, hay que inicializarlo antes.
            SumarRef(num1, num2, ref resultado);
            //Pasar resultado por referencia obligatoriamente, puedes pasarlo sin inicializar por que lo vas a tener que modificar si o si.
            SumarOut(num1, num2, out resultado);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
