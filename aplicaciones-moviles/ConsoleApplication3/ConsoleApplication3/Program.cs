using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static public void suma(int num)
        {
            num = 1 + 1;
            Console.WriteLine(num);
        }
        static public int multiplicar(ref int num)
        {
            return num = 1 * 2;
        }
        static public int dividir(out int hola)
        {
            return hola = 4 / 2;
        }
        static void Main(string[] args)
        {
            int num;
            int hola;

            Fecha f1 = new Fecha(12, 2, 2002),
                    f2 = new Fecha(21, 4, 1992),
                    f3 = new Fecha(15, 6, 199);
            do
            {
                Console.Clear();
                Console.WriteLine("1- Cambiar dia fecha 1");
                Console.WriteLine("2- Imprimir dia fecha 1");
                Console.WriteLine("3- Cambiar mes fecha 2");
                Console.WriteLine("4- Imprimir mes fecha 2");
                Console.WriteLine("5- Cambiar fecha 3");
                Console.WriteLine("6- Imprimir fecha 3");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        int dia = 0;
                        Console.WriteLine("dia: ");
                        dia = Int32.Parse(Console.ReadLine());
                        f1.cambiarDia(dia);
                        break;

                    case 2:
                        Console.WriteLine("dia: " + f1.imprimirDia());
                        Console.ReadKey();
                        break;
                    case 3:
                        int mes = 0;
                        Console.Write("mes: ");
                        mes = Int32.Parse(Console.ReadLine());
                        f2.cambiarMes(mes);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("mes:" + f2.imprimirMes());
                        Console.ReadKey();
                        break;
                    case 5:
                        int op1, op2, op3;
                        Console.WriteLine("dia - mes - año");
                        op1 = Int32.Parse(Console.ReadLine());
                        op2 = Int32.Parse(Console.ReadLine());
                        op3 = Int32.Parse(Console.ReadLine());
                        f3.cambiarFecha(op1, op2, op3);
                        break;
                    case 6:
                        Console.WriteLine("fecha " + f3.imprimirDia() + "-" + f3.imprimirMes() + "-" + f3.imprimirAnio());
                        Console.ReadKey();
                        break;
                    case 7:
                        //resultado por valor (sin guardar).
                        suma(num);
                        Console.ReadKey();
                        break;
                    case 8:
                        //resultado por referencia (se guarda) hay que inicializar antes.
                        num = 0;
                        multiplicar(ref num);
                        Console.WriteLine(num);
                        Console.ReadKey();
                        break;
                    case 9:
                        //Resultado por referencia obligatorio (se guarda) no hay que iniciar por que nos comprometemos a usarlo.
                        dividir(out hola);
                        Console.WriteLine(hola);
                        Console.ReadKey();
                        break;
                }
            } while (num != 12);
             
        }
    }
}
