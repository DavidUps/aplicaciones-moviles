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

        //Devolver el numero de dias desde el 1 de enero del año en curso.

        //Crear 3 fechas y leer los valores de las fechas por pantalla.
        //Crea la mayor de todas las fechas.
        
    }
}
