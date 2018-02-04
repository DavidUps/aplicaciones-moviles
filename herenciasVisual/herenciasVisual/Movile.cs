using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciasVisual.Class
{
    class Movile : Shop
    {
        private string operativeSistem;
        private int batery;

        public Movile(string brand, string name, int ram, int price, string operativeSistem, int batery) : base(brand, name, ram, price)
        {
            this.OperativeSistem = operativeSistem;
            this.Batery = batery;
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


    }
}
