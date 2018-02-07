using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciasV1
{
    class Movile : Shop
    {
        private string operativeSistem;
        private int batery, memory;

        public Movile(string type, string brand, string name, int ram, int price, string operativeSistem, int batery, int memory) : base(type, brand, name, ram, price)
        {
            this.OperativeSistem = operativeSistem;
            this.Batery = batery;
            this.memory = memory;
        }

        public Movile() : base()
        {
            operativeSistem = null;
            batery = 0;
        }

        public string OperativeSistem
        {
            get
            {
                return operativeSistem;
            }

            set
            {
                operativeSistem = value;
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
        public int Memory
        {
            get
            {
                return memory;
            }

            set
            {
                memory = value;
            }
        }

        public string getAllMovile()
        {
            string allMovile = "Marca: " + Brand + " | Modelo: " + Name + " | Ram: " + Ram + " | Precio: " + Price + " | Sistema Operativo: " + OperativeSistem + " | Batetia " + Batery + " | Memoria: " + Memory;
            return allMovile;
        }
    }
}
