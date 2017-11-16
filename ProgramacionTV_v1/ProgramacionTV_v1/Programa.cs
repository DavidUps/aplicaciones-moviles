using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionTV_v1
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

        public void setDatos(string nom,int dur, string cont)
        {
            nombre = nom;
            duracion = dur;
            contenido = cont;
        }

        public void aumentar(int dur)
        {
            duracion += dur;
        }

        public void disminuir(int dur)
        {
            duracion -= dur;
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
            return contenido;
        }
    }
}
