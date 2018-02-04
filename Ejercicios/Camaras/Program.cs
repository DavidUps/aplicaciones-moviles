using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camaras
{
    class Program
    {
        static void Main(string[] args)
        {
            camaraIp[] CamaraIp = new camaraIp[2];
            CamaraIp[0] = new camaraIp("Canon", "x2", "2Kg", "190.165.1.2", "199843928");
            CamaraIp[1] = new camaraIp("Sonic", "x5", "5Kg", "185.160.1.4", "198453875");
            camaraWeb[] CamaraWeb = new camaraWeb[2];
            CamaraWeb[0] = new camaraWeb("Logitec", "x0.5", "500Gr", "2mp", 5);
            CamaraWeb[1] = new camaraWeb("MSI", "x0.2", "250Gr", "1mp", 3);

            CamaraIp[0].setDireccionIp(CamaraIp[1].getDireccionIp());
            CamaraIp[1].setDireccionMac(CamaraIp[0].getDireccionMac());

            CamaraWeb[1].setResolucion(CamaraWeb[0].getResolucion());

            CamaraIp[0].setMarca(CamaraWeb[0].getMarca());

            for(int i=0; i < 2; i++)
            {
                CamaraIp[i].Imprimir();
            }
            for (int i = 0; i < 2; i++)
            {
                CamaraWeb[i].Imprimir();
            }
            for (int i = 0; i < 2; i++)
            {
                CamaraIp[i].Borrar();
                CamaraWeb[i].Borrar();
            }
            for (int i = 0; i < 2; i++)
            {
                CamaraIp[i].Imprimir();
            }
            for (int i = 0; i < 2; i++)
            {
                CamaraWeb[i].Imprimir();
            }
            Console.ReadKey();
        }
    }
}
