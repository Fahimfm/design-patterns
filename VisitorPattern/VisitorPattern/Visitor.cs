using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    interface Visitor
    {
        double visit(FruitItem fruit);
        double visit(VegetableItem veg);
        double visit(DairyItem dairy);
    }
}
