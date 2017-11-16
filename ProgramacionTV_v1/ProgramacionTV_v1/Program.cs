using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionTV_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a;

            Dia[] dia = new Dia[5];
            //inicializo dia
            dia[0] = new Dia("lunes");
            dia[1] = new Dia("martes");
            dia[2] = new Dia("miercoles");
            dia[3] = new Dia("jueves");
            dia[4] = new Dia("vienres");

            for(int i = 0; i < 5; i++)
            {
                dia[i].inicializarHora();
            }

            do
            {
                Console.Clear();
                Console.WriteLine("1.- Asignar un programa nuevo a un día y horario concreto" + "\n" + "2.- Eliminar un programa" + "\n" + "3.- Modificar los minutos de un programa" + "\n" + "4.- Mostrar programación semanal" + "\n" + "5.- Mostrar programación diaria" + "\n" + "6.- Mostrar contenidos por día" + "\n" + "7.- Salir");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("¿Que dia quieres?");
                        Console.WriteLine("Lunes 1 | Martes 2 | Miercoles 3 | Jueves 4 | Vierenes 5");
                        a = Int32.Parse(Console.ReadLine());
                        a -= 1;
                        dia[a].setHora();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("¿Que dia quieres borrar?");
                        Console.WriteLine("Lunes 1 | Martes 2 | Miercoles 3 | Jueves 4 | Vierenes 5");
                        a = Int32.Parse(Console.ReadLine());
                        a -= 1;
                        dia[a].borrar();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("¿Que dia quieres modificar?");
                        Console.WriteLine("Lunes 1 | Martes 2 | Miercoles 3 | Jueves 4 | Vierenes 5");
                        a = Int32.Parse(Console.ReadLine());
                        a -= 1;
                        dia[a].modificar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("¿Que dia quieres imprimir?");
                        Console.WriteLine("Lunes 1 | Martes 2 | Miercoles 3 | Jueves 4 | Vierenes 5");
                        a = Int32.Parse(Console.ReadLine());
                        a -= 1;

                        Console.WriteLine("¿Que hora quieres imprimir?");
                        Console.WriteLine("Primera 1 | Matinal 2 | Mediodia 3 | Tarde 4 | Noche 5");
                        int p;
                        p = Int32.Parse(Console.ReadLine());
                        p -= 1;

                        dia[a].imprimirDia(p);

                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("PROGRAMACION SEMANAL");
                        for(int i = 0; i < 5; i++)
                        {
                            dia[i].imprimir();
                            Console.WriteLine("");
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("¿Que dia quieres sacar?");
                        Console.WriteLine("Lunes 1 | Martes 2 | Miercoles 3 | Jueves 4 | Vierenes 5");
                        a = Int32.Parse(Console.ReadLine());
                        a -= 1;
                        dia[a].contenido();
                        Console.ReadKey();
                        break;
                }
            } while (num != 7);
        }
    }
}
