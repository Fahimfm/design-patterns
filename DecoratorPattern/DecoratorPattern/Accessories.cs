using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Accessories: ICar
    {
        protected string description;
        protected double price;
        protected ICar C;

        public Accessories(ICar c)
        {
            this.C = c;

        }
        public string getDescription()
        {
            return C.getDescription() + " " + this.description;
        }

        public double getPrice()
        {
            return C.getPrice() + this.price;
        }
    }
}
