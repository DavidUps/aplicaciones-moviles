using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camaras
{
    class camaraIp
    {
        string marca;
        string objetivo;
        string peso;
        string direccionMac;
        string direccionIp;
        
        public camaraIp(string n,string o, string p, string dM, string dI)
        {
            marca = n;
            objetivo = o;
            peso = p;
            direccionMac = dM;
            direccionIp = dI;
        }

        public camaraIp()
        {
            marca = "";
            objetivo = "";
            peso = "";
            direccionIp = "";
            direccionMac = "";
        }

        public string getDireccionIp()
        {
            return direccionIp;
        }

        public void setDireccionIp(string direccion)
        {
            direccionIp = direccion;
        }

        public string getDireccionMac()
        {
            return direccionMac;
        }

        public void setDireccionMac(string direccion)
        {
            direccionMac = direccion;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public void Imprimir()
        {
            Console.WriteLine("Marca " + marca + " - Objetivo " + objetivo + " - Peso " + peso + " - Direccion Ip" + direccionIp + " - Direccion Mac" + direccionMac);
        }

        public void Borrar()
        {
            marca = "";
            objetivo = "";
            peso = "";
            direccionIp = "";
            direccionMac = "";
        }
    }
}
