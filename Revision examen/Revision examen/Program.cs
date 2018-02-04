using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno david    = new Alumno("David", "Arribas", 21, 69, "2Dam"),
                   halfonso = new Alumno("Halfonso", "Perez", 22, 75, "1Dam"),
                   carolina = new Alumno("Carolina", "Fernandez", 20, 65, "1Teleco");
                   
           
            int Swicth = 0;

            do
            {
                Console.WriteLine("1.-Cambiar nombres \n 2.- Imprimir nombres");
                Swicth = Int32.Parse(Console.ReadLine());
                switch (Swicth)
                {
                    case 1:
                        Console.Clear();
                        int cambiar = 0;
                        Console.WriteLine("1.-David \n 2.-Halfonso \n 3.-Carolina");
                        cambiar = Int32.Parse(Console.ReadLine());
                        switch (cambiar)
                        {
                            case 1:
                                david.setCambiarNombre();
                                Console.ReadKey();
                                break;
                            case 2:
                                halfonso.setCambiarNombre();
                                Console.ReadKey();
                                break;
                            case 3:
                                carolina.setCambiarNombre();
                                Console.ReadKey();
                                break;
                        }
                       

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(david.imprimirNombres());
                        Console.WriteLine(halfonso.imprimirNombres());
                        Console.WriteLine(carolina.imprimirNombres());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("1.-Cambiar nombres");
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                }
            }while(Swicth != 9);
        }
    }
}
