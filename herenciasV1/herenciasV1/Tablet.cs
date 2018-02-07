using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciasV1
{
    class Tablet : Shop
    {
        private int resource;
        private int batery;



        public Tablet(string type,string brand, string name, int ram, int price, int resource, int batery) : base(type,brand, name, ram, price)
        {
            this.Resource = resource;
            this.Batery = batery;
        }

        public Tablet() : base()
        {
            resource = 0;
            batery = 0;
        }
        public int Resource
        {
            get
            {
                return resource;
            }

            set
            {
                resource = value;
            }
        }

        public int Batery
        {
            get
            {
                return batery;
            }

            set
            {
                batery = value;
            }
        }

        public string getAllTablet()
        {
            string allTablet = "Marca: " + Brand + " | Modelo: " + Name + " | Ram: " + Ram + " | Precio: " + Price + " | Resolucion: " + Resource + " | Bateria: " + Batery;
            return allTablet;
        }
    }
}
