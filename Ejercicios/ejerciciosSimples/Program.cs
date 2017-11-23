using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string cadena;
            int posicion;
            char[] myChar = new char[20];
            char[] myBuffer = new char[20];
            int parar = 0;
            int p = 4,a=0;

            do
            {
                num = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Escribir hola donde quieras");
                Console.WriteLine("Longitud recursiva");
                Console.WriteLine("Calculadora de String");

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Cadena:");
                        cadena = Console.ReadLine();
                        Console.WriteLine("Posicion:");
                        posicion = Int32.Parse(Console.ReadLine());
                        for (int i = parar; i < myBuffer.Length; i++)
                        {
                            myChar[i] = myBuffer[i];
                        }
                        for (int i = 0; i < cadena.Length;i++)
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
                            for (int i=parar; i < myBuffer.Length; i++)
                            {
                                myChar[i] = myBuffer[i-4];
                            }
                            a++;
                            

                        } while (a != p);
                        
                        for (int i = 0; i < myChar.Length; i++)
                        {
                            Console.Write(myChar[i]);
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            } while (num != 4);
        }
    }
}
