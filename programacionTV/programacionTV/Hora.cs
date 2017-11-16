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

        public Programa setHora(string texto, Programa p)
        {
            texto = horario;


            string nombre, contenido;
            int duracion;

            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Duracion: ");
            duracion = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Contenido: ");
            contenido = Console.ReadLine();

            p.setPrograma(nombre, duracion, contenido);

            return p;
        }

        public void deleteProgram(Programa p)
        {
            string nombre= "", contenido ="";
            int duracion = 0;

            p.setPrograma(nombre, duracion, contenido);
        }

        public void aumentarMinutos(Programa p)
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

        

        public string getNombre(Programa p)
        {
            return p.getNombre();
        }

        public int getDuracion(Programa p)
        {
            return p.getDuracion();
        }

        public string getContenido(Programa p)
        {
            return p.getContenido();
        }

        public Programa inicializar()
        {
            Programa p = new Programa("", 0, "");
            return p;
        }


    }
}
