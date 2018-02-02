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
        public bool Anio()
        {

            if (anio % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            if (anio % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            if (anio % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Aumentar en el mes en 1 y cambar de año si es 12 + 1.
        public void sumMes()
        {
            mes = mes + 1;
            if (mes == 13)
            {
                this.anio ++;
                this.mes = 1;
            }
                
        }
        //Devolver el numero de dias desde el 1 de enero del año en curso.
        public int Dia()
        {
            int nDias = 0;
            int[] tablaMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if(Anio())
            {
                tablaMes[1] = 29;
            }else
            {
                tablaMes[1] = 28;
            }
            for (int i = 0; i<= mes -1; i++)
            {
                nDias += tablaMes[i]; 
            }
            return nDias;
        }

        public int Mes()
        {
            return mes;
        }
        //Crear 3 fechas y leer los valores de las fechas por pantalla.
        //Crea la mayor de todas las fechas.
        public bool esMayor(Fecha f)
        {
            if((anio > f.anio) || (anio == f.anio) && (mes > f.mes) || (anio == f.anio) && (mes > f.mes) && (dia == f.dia))
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        public string Imprimir()
        {
            return dia + "/" + mes + "/" + anio;
        }
    }
}
