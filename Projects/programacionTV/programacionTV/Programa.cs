using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionTV
{
    class Programa
    {
        string nombre;
        int duracion;
        string contenido;
        

        public Programa()
        {
            nombre = "";
            duracion = 0;
            contenido = "";
        }

        public void setTipo()
        {
            Console.Write("Nombre:");
            this.nombre = Console.ReadLine();
            Console.Write("Duracion:");
            this.duracion = Int32.Parse(Console.ReadLine());
            Console.Write("Contenido:");
            this.contenido = Console.ReadLine();
        }
        public void setDatos()
        {
            this.nombre = "";
            this.duracion = 0;
            this.contenido = "";
        }

        public void setAumentoHorario()
        {
            int tiempo;
            string aum;
            Console.Write("quieres aumentar o disminuir");
            aum = Console.ReadLine();
            if (aum.Equals("aumentar"))
            {
                Console.Write("Cuanto tiempo quieres aumentar:");
                tiempo = Int32.Parse(Console.ReadLine());
                this.duracion += tiempo;

            }
            else
            {
                Console.Write("Cuanto tiempo quieres disminuir:");
                tiempo = Int32.Parse(Console.ReadLine());
                this.duracion -= tiempo;
            }
        }
        public void imprimirFecha()
        {
            Console.WriteLine("Nombre" + nombre + "\n" + "Duración: " + duracion + "\n" + "Contenido: " + contenido + "\n");
        }

    }
}
