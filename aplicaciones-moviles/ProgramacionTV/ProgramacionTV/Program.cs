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
                        for(int a = 0; a < 5; a++)
                        {
                            dia[a].iniciarHora();
                        }
                        Console.WriteLine("¿Qué día?");
                        texto = Console.ReadLine();
                        for(int i = 0; i < 5; i++)
                        {
                            if (dia[i].getDia().Equals(texto))
                            {
                                dia[i].setDia(texto);
                            }      
                        }
                        Console.ReadKey();
                        break;
                    //eliminar programa
                    case 2:
                        Console.WriteLine("¿Que dia?");
                        texto = Console.ReadLine();
                        for (int i = 0; i < 5; i++)
                        {
                            if (dia[i].getDia().Equals(texto))
                            {
                                dia[i].getHora(texto);
                            }

                        }
                        Console.ReadKey();
                        break;
                    //modificar minutos
                    case 3:
                        Console.WriteLine("¿Que dia?");
                        texto = Console.ReadLine();
                        for (int i = 0; i < 5; i++)
                        {
                            if (dia[i].getDia().Equals(texto))
                            {
                                dia[i].cambioMinutos(texto);
                            }

                        }
                        Console.ReadKey();
                        break;
                    //Mostrar programación semanal
                    case 4:
                        for(int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Dia: " + dia[i].getDia() );
                        }
                        
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
