using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Car : ICar
    {
        protected string description;
        protected double price;
        public Car(string Description, double Price)
        {
            this.description = Description;
            this.price = Price;
        }
        public string getDescription()
        {
            return this.description;
        }

        public double getPrice()
        {
            return this.price;
        }
    }
}
