using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciasV1
{
    class Computer : Shop
    {
        private int speed;
        private int port;

        public Computer(string type, string brand, string name, int ram, int price, int speed, int port) : base(type,brand, name, ram, price)
        {
            this.Speed = speed;
            this.Port = port;
        }

        public Computer() : base()
        {
            speed = 0;
            port = 0;
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public int Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }

        public String getAllComputer()
        {
            string allComputer = "Marca: " + Brand + " | Modelo: " +  Name + " | Ram: " + Ram + " | Precio: " + Price + " | Velocidad: " + Speed + " | Puertos: " + Port;
            return allComputer;
        }

    }
}
