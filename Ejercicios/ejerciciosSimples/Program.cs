using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosSimples
{
    class Program
    {
        static void uno()
        {
            
            string cadena;
            int posicion;
            char[] myChar = new char[20];
            char[] myBuffer = new char[20];
            int parar = 0;
            int p = 4, a = 0;
            Console.WriteLine("Cadena:");
            cadena = Console.ReadLine();
            Console.WriteLine("Posicion:");
            posicion = Int32.Parse(Console.ReadLine());
            for (int i = parar; i < myBuffer.Length; i++)
            {
                myChar[i] = myBuffer[i];
            }
            for (int i = 0; i < cadena.Length; i++)
            {
                myChar[i] = cadena[i];
            }
            for (int i = 0; i < myChar.Length; i++)
            {
                myBuffer[i] = myChar[i];
            }
            do
            {
                myChar[parar] = myBuffer[parar];
                parar++;
            } while (parar != posicion);
            do
            {
                myChar[parar] = 'h';
                parar++;
                a++;
                myChar[parar] = 'o';
                parar++;
                a++;
                myChar[parar] = 'l';
                parar++;
                a++;
                myChar[parar] = 'a';
                parar++;
                for (int i = parar; i < myBuffer.Length; i++)
                {
                    myChar[i] = myBuffer[i - 4];
                }
                a++;


            } while (a != p);

            for (int i = 0; i < myChar.Length; i++)
            {
                Console.Write(myChar[i]);
            }
        }
        static void recursividad(char[] frase, int contador)
        {
            if (frase[contador] != '\0')
            {
                contador++;
                recursividad(frase, contador);
            }else
            {
                Console.WriteLine("Tiene: " + contador);
            }
        }
        static void Main(string[] args)
        {
            int num;
            int contador=0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Escribir hola donde quieras");
                Console.WriteLine("Longitud recursiva");
                Console.WriteLine("Calculadora de String");
                num = Int32.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        uno();
                        Console.ReadKey();
                        break;
                    case 2:
                        string fraseString;

                        char[] frase = new char[20];
                        Console.WriteLine("Escribir");
                        fraseString = Console.ReadLine();
                        for (int i = 0; i < fraseString.Length; i++)
                        {
                            frase[i] = fraseString[i];
                        }
                        recursividad(frase, contador);
                        Console.ReadKey();
                        break;
                    case 3:
                       
                        int op1 = 0;
                        int op2 = 0;
                        int acum = 0;
                        string lectura;
                        string operador;
                        Console.WriteLine("Escribir");
                        lectura = Console.ReadLine();
                        for(int i = 0; i < lectura.Length; i++)
                        {
                        }
                        Console.WriteLine(op1);
                        Console.WriteLine(op2);
                        Console.ReadKey();
                        break;
                }
            } while (num != 4);
        }
    }
}
