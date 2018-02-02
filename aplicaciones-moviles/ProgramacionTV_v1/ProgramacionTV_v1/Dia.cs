using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionTV_v1
{
    class Dia
    {
        String dia;

        Hora[] hora = new Hora[5];

        //Constructor
        public Dia(string d)
        {
            dia = d;
        }
        //inicializar hora
        public void inicializarHora()
        {
            hora[0] = new Hora("Primera ");
            hora[1] = new Hora("Matinal ");
            hora[2] = new Hora("Mediodia");
            hora[3] = new Hora("Tarde   ");
            hora[4] = new Hora("Noche   ");
        }

        public void setHora()
        {
            Console.WriteLine("¿Que hora quieres?");
            Console.WriteLine("Primera 1 | Matinal 2 | Mediodia 3 | Tarde 4 | Noche 5");
            int a;
            a = Int32.Parse(Console.ReadLine());
            a -= 1;
            hora[a].setHora();
        }

        public void borrar()
        {
            Console.WriteLine("¿Que hora quieres?");
            Console.WriteLine("Primera 1 | Matinal 2 | Mediodia 3 | Tarde 4 | Noche 5");
            int a;
            a = Int32.Parse(Console.ReadLine());
            a -= 1;
            hora[a].borrar();
        }

        public void modificar()
        {
            Console.WriteLine("¿Que hora quieres?");
            Console.WriteLine("Primera 1 | Matinal 2 | Mediodia 3 | Tarde 4 | Noche 5");
            int a;
            a = Int32.Parse(Console.ReadLine());
            a -= 1;
            hora[a].modificar();
        }
        public void imprimir()
        {
            Console.Write("Dia: " + dia + "\n");
            for (int i = 0; i < 5; i++)
            {
                hora[i].imprimir();
                Console.WriteLine("");
            }
        }
        public void imprimirDia(int p)
        {
            Console.Write("Dia: " + dia + "\n");
            hora[p].imprimir();
        }
        public void contenido()
        {
            int inf=0,entr=0,con=0,pel=0,ser=0;
            for(int i = 0; i < 5; i++)
            {
                if (hora[i].getContenido().Equals("informativo"))
                {
                    inf = hora[i].getDuracion() + hora[i + 1].getDuracion();
                }
                if (hora[i].getContenido().Equals("entretenimiento"))
                {
                    entr = hora[i].getDuracion() + hora[i + 1].getDuracion();
                }g4
                if (hora[i].getContenido().Equals("concurso"))
                {
                    con = hora[i].getDuracion() + hora[i + 1].getDuracion();
                }
                if (hora[i].getContenido().Equals("pelicula"))
                {
                    pel = hora[i].getDuracion() + hora[i + 1].getDuracion();
                }
                if (hora[i].getContenido().Equals("serie"))
                {
                    ser = hora[i].getDuracion() + hora[i + 1].getDuracion();
                }
            }
            Console.WriteLine("informativo: " + inf + "\n" +
                                    "entretenimiento: " + entr + "\n" +
                                    "concurso: " + con + "\n" +
                                    "pelicula: " + pel + "\n" +
                                    "serie: " + ser + "\n");

           // inf = 0; entr = 0; con = 0; pel = 0; ser = 0;
        }
    }
}
