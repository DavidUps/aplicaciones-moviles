using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Fecha
    {
        int dia, mes, anio;

        public Fecha()
        {
            dia = 2;
            mes = 2;
            anio = 2002;
        }

        public Fecha(int d, int m, int a)
        {
            d = dia;
            m = mes;
            a = anio;
        }

        public void cambiarDia(int op1)
        {
            this.dia = op1;
        }

        public int imprimirDia()
        {
            return this.dia;
        }

        public void cambiarMes(int op1)
        {
            this.mes = op1;
        }

        public int imprimirMes()
        {
            return this.mes;
        }

        public void cambiarFecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        public int imprimirAnio()
        {
            return this.anio;
        }
    }
}
