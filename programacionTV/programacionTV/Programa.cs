using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionTV
{
    class Programa
    {
        private string nombre;
        private int duracion;
        private string contenidos;

        public Programa(string n, int d, string c)
        {
            n = nombre;
            d = duracion;
            c = contenidos;
        }

        public void setPrograma(string nombre, int duracion, string contenidos)
        {
            this.nombre = nombre;
            this.duracion = duracion;
            this.contenidos = contenidos;
        }

        public void aumentar(int minutos)
        {
            this.duracion += minutos;
        }

        public void disminuir(int minutos)
        {
            this.duracion -= minutos;
        }

        public string getNombre()
        {
            return nombre;
        }
        public int getDuracion()
        {
            return duracion;
        }

        public string getContenido()
        {
            return contenidos;
        }
    }
}
