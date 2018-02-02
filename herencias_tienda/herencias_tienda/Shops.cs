using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencias_tienda
{
    class Shops
    {
        private string brands, name, speed, operativeSistem, resolution;
        private int ram, price, batery;

        public Shops(String brands, String name, int ram, int price)
        {
            this.brands = brands;
            this.name = name;
            this.ram = ram;
            this.price = price;
        }

        public Shops()
        {
            brands = null;
            name = null;
            ram = 0;
            price = 0;
        }

        public String getMarca()
        {
            return brands;
        }
        public void setMarca(String brands)
        {
            this.brands = brands;
        }

        public String getNombre()
        {
            return name;
        }

        public void setNombre(String name)
        {
            this.name = name;
        }

        public int getRam()
        {
            return ram;
        }

        public void setRam(int ram)
        {
            this.ram = ram;
        }

        public int getPrice()
        {
            return price;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public string getSpeed()
        {
            return speed;
        }

        public void setSpeed(String speed)
        {
            this.speed = speed;
        }

        public String getOperativeSistem()
        {
            return operativeSistem;
        }
        public void setOperativeSistem(String operativeSistem)
        {
            this.operativeSistem = operativeSistem;
        }

        public int getBatery()
        {
            return batery;
        }
        public void setBatery(int batery)
        {
            this.batery = batery;
        }

        public string getResolution()
        {
            return resolution;
        }
        public void setResolution(string resolution)
        {
            this.resolution = resolution;
        }
    }
}
