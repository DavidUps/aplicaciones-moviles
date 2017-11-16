using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionTV
{
    class Dia
    {
        private string dia;

        Hora[] hora = new Hora[5];
        


        public Dia(string d)
        {
            d = dia;
        }

        public string getDia()
        {
            return dia;
        }

        public void setDia(string texto)
        {
            dia = texto;
            Console.WriteLine("¿En qué rango? | 8:00 – 10:00: primera, 10:00 – 14:00: matinal, 14:00 – 16:00: mediodia, 16:00 – 20:00: tarde, 20:00 – 24:00: noche");
            texto = Console.ReadLine();
            for(int i = 0; i < 5; i++)
            {
                if (hora[i].getHora().Equals(texto))
                {
                    hora[i].setHora(texto, hora[i].inicializar());
                }
            }

        }

        public void getHora(string texto)
        {
            Console.WriteLine("¿En qué rango? | 8:00 – 10:00: primera, 10:00 – 14:00: matinal, 14:00 – 16:00: mediodia, 16:00 – 20:00: tarde, 20:00 – 24:00: noche");
            texto = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (hora[i].getHora().Equals(texto))
                {
                    hora[i].deleteProgram(hora[i].inicializar());
                }
            }

        }

        public void cambioMinutos(string texto)
        {
            Console.WriteLine("¿En qué rango? | 8:00 – 10:00: primera, 10:00 – 14:00: matinal, 14:00 – 16:00: mediodia, 16:00 – 20:00: tarde, 20:00 – 24:00: noche");
            texto = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (hora[i].getHora().Equals(texto))
                {
                    hora[i].aumentarMinutos(hora[i].inicializar());
                }
            }

        }
        public void iniciarHora()
        {
            hora[0] = new Hora("primera");
            hora[1] = new Hora("matinal");
            hora[2] = new Hora("mediodia");
            hora[3] = new Hora("tarde");
            hora[4] = new Hora("noche");
        }

        public string getHora(int i)
        {
           return hora[i].getHora();
        }
    }
}
