using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionTV
{
    class Program
    {
        static void Main(string[] args)
        {
            int Switch;
            string texto;

            Dia[] dia = new Dia[5];

            dia[0] = new Dia("lunes");
            dia[1] = new Dia("martes");
            dia[2] = new Dia("miercoles");
            dia[3] = new Dia("jueves");
            dia[4] = new Dia("viernes");

            do
            {
                Console.WriteLine("1.- Asignar un programa nuevo a un día y horario concreto" + "\n"
                                + "2.- Eliminar un programa" + "\n"
                                + "3.- Modificar los minutos de un programa" + "\n"
                                + "4.- Mostrar programación semanal" + "\n"
                                + "5.- Mostrar programación diaria" + "\n"
                                + "6.- Mostrar contenidos por día" + "\n"
                                + "7.- Salir");
                Switch = Int32.Parse(Console.ReadLine());
                switch (Switch)
                {
                    //crear programa
                    case 1:
                        Console.WriteLine("¿Qué día?");
                        texto = Console.ReadLine();
                        for(int i = 0; i < 5; i++)
                        {
                            if (dia[i].getDia().Equals(texto))
                            {
                                dia[i].setDia(texto);
                            }
                                
                        }
                        
                        break;
                    //eliminar programa
                    case 2:
                        break;
                    //modificar minutos
                    case 3:
                        break;
                    //Mostrar programación semanal
                    case 4:
                        break;
                    //Mostrar programación diaria
                    case 5:
                        
                        break;
                    //Mostrar contenidos por día
                    case 6:
                        break;
                }
            } while (Switch != 7);
        }
    }
}
