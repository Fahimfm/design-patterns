using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class FruitItem : GeneralItem, Element
    {
        public FruitItem(string fruitname, double fruitprice) : base(fruitname, fruitprice)
        {

        }
        public override double accept(Visitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
