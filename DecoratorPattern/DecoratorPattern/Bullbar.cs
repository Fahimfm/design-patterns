using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Bullbar: Accessories
    {
        public Bullbar(ICar car) : base(car)
        {
            description = "Bullbar Added";
            price = 400;
        }
    }
}
