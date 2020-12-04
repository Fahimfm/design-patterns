using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Arco : Accessories
    {
        public Arco(ICar car) : base(car)
        {
            description = "Arco Added";
            price = 200;
        }
    }
}
