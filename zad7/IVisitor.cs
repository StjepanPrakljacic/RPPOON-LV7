using System;
using System.Collections.Generic;
using System.Text;

namespace zad7
{
    interface IVisitor
    {
        double Visit(DVD DVDItem);
        double Visit(VHS VHSItem);
        double Visit(Book BookItem);

    }
}
