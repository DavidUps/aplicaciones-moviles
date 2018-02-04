using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciasVisual.Class
{

    class Tablet : Shop
    {

        private int resource;
        private int batery;



        public Tablet(string brand, string name, int ram, int price, int resource, int batery) : base(brand, name, ram, price)
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
    }
    
    }
}
