using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class SaleDiscount : Visitor
    {
        public SaleDiscount()
        {

        }


        public double visit(FruitItem fruit)
        {
            return 0.90 * fruit.GetPrice();
        }

        public double visit(VegetableItem Veg)
        {
            return 0.90 * Veg.GetPrice();
        }

        public double visit(DairyItem Dairy)
        {
            return 0.95 * Dairy.GetPrice();
        }
    }
}
