using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Fecha
    {
        //atributos
        int dia, mes, anio;

        //Constructores
        public Fecha()
        {
            dia = 1;
            mes = 1;
            anio = 1970;
        }

        public Fecha(int d, int m, int a)
        {
            dia = d;
            mes = m;
            anio = a;
        }
        //fecha se corresponde a un año bisiesto.
        public int Anio()
        {
            return this.anio;
        }
        //Aumentar en el mes en 1 y cambar de año si es 12 + 1.
        public void sumMes()
        {
            mes = mes + 1;
            if (mes == 13)
            {
                this.anio = anio + 1;
                this.mes = 0;
            }
                
        }
        //Devolver el numero de dias desde el 1 de enero del año en curso.
        public int Dia()
        {
            return dia;
        }

        public int Mes()
        {
            return mes;
        }
        //Crear 3 fechas y leer los valores de las fechas por pantalla.
        //Crea la mayor de todas las fechas.
        public void imprimirFechas()
        {
            Console.Write(this.dia  + "-");
            Console.Write(this.mes  + "-");
            Console.Write(this.anio);
            Console.Write("\n");
        }
    }
}
