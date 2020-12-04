using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class SnowTyres : Accessories
    {
        public SnowTyres(ICar c) : base(c)
        {
            description = "Snowtyres Added";
            price = 1000;
        }
    }
}
