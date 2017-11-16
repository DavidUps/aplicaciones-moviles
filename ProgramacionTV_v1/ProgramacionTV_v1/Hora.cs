using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionTV_v1
{
    class Hora
    {
        String hora;
        //Inicializo programa
        Programa programa = new Programa();
        public Hora(string h)
        {
            hora = h;
        }
        //Meter datos
        public void setHora()
        {
            string nom,cont;
            int dur;
            Console.Clear();

            Console.Write("Nombre: ");
            nom = Console.ReadLine();

            Console.Write("Duración: ");
            dur = Int32.Parse(Console.ReadLine());

            Console.Write("Contenido: ");
            cont = Console.ReadLine();

            programa.setDatos(nom,dur,cont);

            Console.WriteLine("Datos Creados");
            Console.ReadKey();
        }

        public void borrar()
        {
            string nom="", cont="";
            int dur=0;
            Console.Clear();
            programa.setDatos(nom, dur, cont);
            Console.WriteLine("Datos Borrados");
            Console.ReadKey();
        }
        public void modificar()
        {
            String txt;
            int dur = 0;
            Console.Clear();
            Console.WriteLine("¿Quieres aumentar o disminuir?");
            txt = Console.ReadLine();
            if (txt.Equals("aumentar"))
            {
                Console.WriteLine("¿Cuanto?");
                dur = Int32.Parse(Console.ReadLine());
                programa.aumentar(dur);
            }
            else
            {
                Console.WriteLine("¿Cuanto?");
                dur = Int32.Parse(Console.ReadLine());
                programa.disminuir(dur);
            }
            Console.WriteLine("Datos Modificados");
            Console.ReadKey();
        }
        public void imprimir()
        {
            Console.Write("Hora: " + hora + "|" + "Nombre: " + programa.getNombre() + "|" + "Duracion: " + programa.getDuracion() + "|" + "Contenido: " + programa.getContenido());
        }
        public int getDuracion()
        {
            return programa.getDuracion();
        }
        public string getContenido()
        {
            return programa.getContenido();
        }
    }
}
