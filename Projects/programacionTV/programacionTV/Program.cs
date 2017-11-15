using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionTV
{
    class Program
    {
        static void Main(string[] args)
        {
            int Switch;
            string texto;

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
                        Console.WriteLine("¿En qué rango? | 8:00 – 10:00: primera, 10:00 – 14:00: matinal, 14:00 – 16:00: mediodia, 16:00 – 20:00: tarde, 20:00 – 24:00: noche");
                        texto += Console.ReadLine();
                        Programa texto1 = new Programa();
                        texto1.setTipo();
                        Console.ReadKey();
                        break;
                    //eliminar programa
                    case 2:
                        Console.WriteLine("¿Qué día?");
                        texto = Console.ReadLine();
                        Console.WriteLine("¿En qué rango? | 8:00 – 10:00: primera, 10:00 – 14:00: matinal, 14:00 – 16:00: mediodia, 16:00 – 20:00: tarde, 20:00 – 24:00: noche");
                        texto += Console.ReadLine();
                        texto1.setDatos();
                        Console.ReadKey();
                        break;
                    //modificar minutos
                    case 3:
                        Console.WriteLine("¿Qué día?");
                        texto = Console.ReadLine();
                        Console.WriteLine("¿En qué rango? | 8:00 – 10:00: primera, 10:00 – 14:00: matinal, 14:00 – 16:00: mediodia, 16:00 – 20:00: tarde, 20:00 – 24:00: noche");
                        texto += Console.ReadLine();
                        texto1.setAumentoHorario();
                        Console.ReadKey();
                        break;
                    //Mostrar programación semanal
                    case 4:
                        texto1.imprimirFecha();
                        break;
                    //Mostrar programación diaria
                    case 5:
                        string dia;
                        Console.Write("dia:");
                        dia = Console.ReadLine();
                        if (dia.Equals("lunes"))
                        {
                            lunesprimera.imprimirFecha();
                            lunesmatinal.imprimirFecha();
                            lunesmediodia.imprimirFecha();
                            lunestarde.imprimirFecha();
                            lunesnoche.imprimirFecha();
                        }
                        if (dia.Equals("martes"))
                        {
                            martesprimera.imprimirFecha();
                            martesmatinal.imprimirFecha();
                            martesmediodia.imprimirFecha();
                            martestarde.imprimirFecha();
                            martesnoche.imprimirFecha();
                        }
                        if (dia.Equals("miercoles"))
                        {
                            miercolesprimera.imprimirFecha();
                            miercolesmatinal.imprimirFecha();
                            miercolesmediodia.imprimirFecha();
                            miercolestarde.imprimirFecha();
                            miercolesnoche.imprimirFecha();
                        }
                        if (dia.Equals("jueves"))
                        {
                            juevesprimera.imprimirFecha();
                            juevesmatinal.imprimirFecha();
                            juevesmediodia.imprimirFecha();
                            juevestarde.imprimirFecha();
                            juevesnoche.imprimirFecha();
                        }
                        if (dia.Equals("viernes"))
                        {
                            viernesprimera.imprimirFecha();
                            viernesmatinal.imprimirFecha();
                            viernesmediodia.imprimirFecha();
                            viernestarde.imprimirFecha();
                            viernesnoche.imprimirFecha();
                        }
                        Console.ReadKey();
                        break;
                    //Mostrar contenidos por día
                    case 6:
                        break;
                }
            } while (Switch != 7);
        }
    }
}
