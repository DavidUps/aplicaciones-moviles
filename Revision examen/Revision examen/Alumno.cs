using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_examen
{
    class Alumno
    {
        string nombre, apellido, curso;
        int edad, peso;

        public Alumno()
        {
            nombre = "nombre";
            apellido = "apellido";
            curso = "curso";
            edad = 0;
            peso = 0;
        }

        public Alumno(string n, string a, int e, int p, string c)
        {
            n = nombre;
            a = apellido;
            e = edad;
            p = peso;
            c = curso;
        }

        public string setCambiarNombre()
        {
            string cambio;
            Console.WriteLine("Nombre: ");
            cambio = Console.ReadLine();
            return this.nombre;
        }

        public string imprimirNombres()
        {
            return this.nombre;
        }
    }
}
