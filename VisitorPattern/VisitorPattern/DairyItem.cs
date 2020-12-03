using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class DairyItem: GeneralItem, Element
    {
        public DairyItem(string Dairyname, double Dairyprice) : base(Dairyname, Dairyprice)
        {

        }
        public override double accept(Visitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
