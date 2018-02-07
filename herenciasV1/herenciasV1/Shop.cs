using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciasV1
{
    class Shop
    {
        private string brand, name, type;
        private int ram, price;

        public Shop(string type,string brand, string name, int ram, int price)
        {
            this.type = type;
            this.brand = brand;
            this.name = name;
            this.ram = ram;
            this.price = price;
        }
        
        public Shop()
        {
            type = null;
            brand = null;
            name = null;
            ram = 0;
            price = 0;
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
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

        public int getPrice()
        {
            return price;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }
        public void setMorePrice(int price)
        {
            this.price += price;
        }
        public void setLessPrice(int price)
        {
            this.price -= price;
        }

        public int getRam()
        {
            return ram;
        }
        public void setRam(int ram)
        {
            this.ram = ram;
        }

        public void setMoreRam(int ram)
        {
            this.ram += ram;
        }
        public void setLessRam(int ram)
        {
            this.ram -= ram;
        }
    }
}
