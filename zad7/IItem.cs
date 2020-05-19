using System;
using System.Collections.Generic;
using System.Text;

namespace zad7
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
