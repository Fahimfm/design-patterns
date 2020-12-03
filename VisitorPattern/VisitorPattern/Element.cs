using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    interface Element
    {
        double accept(Visitor visitor);
    }
}
