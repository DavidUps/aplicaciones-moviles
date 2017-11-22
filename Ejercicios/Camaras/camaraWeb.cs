using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camaras
{
    class camaraWeb
    {
        string marca;
        string objetivo;
        string peso;
        string resolicion;
        int valorMaxZoom;

        public camaraWeb(string m, string o, string p, string r, int v)
        {
            marca = m;
            objetivo = o;
            peso = p;
            resolicion = r;
            valorMaxZoom = v;
        }

        public camaraWeb()
        {
            marca = "";
            objetivo = "";
            peso = "";
            resolicion = "";
            valorMaxZoom = 0;
        }

        public string getResolucion()
        {
            return resolicion;
        }

        public void setResolucion(string res)
        {
            resolicion = res;
        }
           
        public string getMarca()
        {
            return marca;
        }
        public void Imprimir()
        {
            Console.WriteLine("Marca " + marca + " - Objetivo " + objetivo + " - Peso " + peso + " - Resolucion" + resolicion + " - Valor Maximo Zoom" + valorMaxZoom);
        }

        public void Borrar()
        {
            marca = "";
            objetivo = "";
            peso = "";
            resolicion = "";
            valorMaxZoom = 0;
        }

    }
}
