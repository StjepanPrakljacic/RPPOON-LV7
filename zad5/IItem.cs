using System;
using System.Collections.Generic;
using System.Text;

namespace zad5
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
