using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class GoldenDiscount: Visitor
    {
        public GoldenDiscount()
        {

        }
        public double visit(FruitItem fruit)
        {

            return 0.85 * fruit.GetPrice();
        }

        public double visit(VegetableItem Veg)
        {
            return 0.85 * Veg.GetPrice();
        }

        public double visit(DairyItem Dairy)
        {
            return 0.85 * Dairy.GetPrice();
        }
    }
}
