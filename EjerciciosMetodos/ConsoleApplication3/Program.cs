using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static int ejercicio1(double num)
        {
            int combertir = Convert.ToInt32(num);
            return combertir;
            //Tambien poniendo retunr (int)num1.
        }

        public static int ejercicio2(double num1, ref int num2)
        {
            num2 = (int)num1;
            return num2;
        }

        public static int ejercicio3(ref double num1)
        {
            return (int)num1;
        }

        public static int ejercicio4(double num1, ref int num2)
        {
            num2 = (int)num1;
            return num2;
        }
        static void Main(string[] args)
        {
            int switchNum = 0;
            double num1 = 764.783;
            int num2 = 0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("1.- Un parametro de tipo real y devuelve el número tras truncar la parte decimal a 0 \n" +
                                  "2.- Un parametro de tipo real y otro de tipo entero. El método almacena sobre el segundo parámetro el número tras truncar la parte decimal a 0 \n" +
                                  "3.- Un parametro de tipo real. El método almacena sobre el primer parámetro el número tras truncar la parte decimal a 0 \n"+
                                  "4.- Un parámetro de tipo real y otro parámetro de tipo entero y devuelve el número tras truncar la parte decimal a los decimales indicados por el segundo parámetro \n" +
                                  "5.- Un parámetro de tipo real, otro parámetro de tipo entero y de tipo real. El método almacena sobre el tercer parámetro el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro \n" +
                                  "6.- Un parámetro de tipo real y otro de tipo entreo. Almacena sobre el primer parámetro el número tras truncar la parte decumal de los decimales indicado por el segundo parámetro \n" +
                                  "7.- Para salir"
                                  );
                

                switchNum = Int32.Parse(Console.ReadLine());
                switch(switchNum)
                {
                     case 1:
                        Console.Clear();
                        Console.WriteLine("1.- Un parametro de tipo real y devuelve el número tras truncar la parte decimal a 0");
                        Console.WriteLine(ejercicio1(num1));
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("2.- Un parametro de tipo real y otro de tipo entero. El método almacena sobre el segundo parámetro el número tras truncar la parte decimal a 0 ");
                        Console.WriteLine(ejercicio2(num1, ref num2));
                        //Lo pongo a 0 por si lo uso otra vez en el progama
                        //Quitar para comprobar que se guarda en num2 antes de ponerlo a 0
                        //Console.WriteLine(num2);
                        num2 = 0;
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("3.- Un parametro de tipo real. El método almacena sobre el primer parámetro el número tras truncar la parte decimal a 0");
                        Console.WriteLine(ejercicio3(ref num1));
                        //Lo pongo a 764.783 para usarlo en más
                        num1 = 764.783;
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4.- Un parámetro de tipo real y otro parámetro de tipo entero y devuelve el número tras truncar la parte decimal a los decimales indicados por el segundo parámetro");
                        Console.WriteLine(ejercicio4(num1, ref num2));
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("5.- Un parámetro de tipo real, otro parámetro de tipo entero y de tipo real. El método almacena sobre el tercer parámetro el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro");

                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("6.- Un parámetro de tipo real y otro de tipo entreo. Almacena sobre el primer parámetro el número tras truncar la parte decumal de los decimales indicado por el segundo parámetro");

                        Console.ReadLine();
                        break;
                    
                }
            } while (switchNum != 7);
        }
    }
}
