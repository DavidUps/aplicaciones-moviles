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
        Programa[] prog = new Programa[5];

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
            string nombre, contenido;
            int duracion, contador = 0;

            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Duracion: ");
            duracion = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Contenido: ");
            contenido = Console.ReadLine();

            prog[contador].setPrograma(nombre, duracion, contenido);
            contador++;
            Console.ReadKey();
        }
    }
}
