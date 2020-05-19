using System;
using System.Collections.Generic;
using System.Text;

namespace zad6
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
