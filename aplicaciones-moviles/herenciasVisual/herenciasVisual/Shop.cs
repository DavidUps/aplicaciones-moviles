using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciasVisual.Class
{
    class Shop
    {
        private string brand, name;
        private int ram, price;

        public Shop(string brand, string name, int ram, int price)
        {
            this.brand = brand;
            this.name = name;
            this.ram = ram;
            this.price = price;
        }

        public Shop()
        {
            brand = null;
            name = null;
            ram = 0;
            price = 0;
        }

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Ram
        {
            get
            {
                return ram;
            }

            set
            {
                ram = value;
            }
        }
    }
}
