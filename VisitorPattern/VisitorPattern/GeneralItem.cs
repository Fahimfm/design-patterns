using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class GeneralItem: Element
    {
        string ItemName;
        double ItemPrice;

        public GeneralItem(string itemname, double itemprice)
        {
            ItemName = itemname;
            ItemPrice = itemprice;
        }

        public double GetPrice()
        {

            return ItemPrice;
        }

        public string GetName()
        {

            return ItemName;
        }



        public virtual double accept(Visitor visitor)
        {
            return 0.0;
        }
    }
}
