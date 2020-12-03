using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class VegetableItem: GeneralItem, Element
    {
        public VegetableItem(string VegItem, double VegPrice) : base(VegItem, VegPrice)
        {

        }

        public override double accept(Visitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
