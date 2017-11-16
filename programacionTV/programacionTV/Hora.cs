using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionTV
{
    class Hora
    {
        private string horario;

        public Hora(string h)
        {
            h = horario;
        }

        
        public string getHora()
        {
            return horario;
        }

        public void setHora(string texto)
        {
            texto = horario;

            Programa p = new Programa("", 0, "");

            string nombre, contenido;
            int duracion;

            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Duracion: ");
            duracion = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Contenido: ");
            contenido = Console.ReadLine();

            p.setPrograma(nombre, duracion, contenido);
        }

        public void deleteProgram()
        {
            string nombre= "", contenido ="";
            int duracion = 0;

            p.setPrograma(nombre, duracion, contenido);
        }

        public void aumentarMinutos()
        {
            int minutos;
            string signo;
            Console.WriteLine("¿Que quieres aumentar o disminuir?");
            signo = Console.ReadLine();
            if (signo.Equals("aumentar"))
            {
                Console.WriteLine("numero: ");
                minutos = Int32.Parse(Console.ReadLine());
                p.aumentar(minutos);
            }
            else
            {
                Console.WriteLine("numero: ");
                minutos = Int32.Parse(Console.ReadLine());
                p.disminuir(minutos);
            }
        }


    }
}
