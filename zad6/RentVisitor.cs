using System;
using System.Collections.Generic;
using System.Text;

namespace zad6
{
    class RentVisitor : IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
                return Double.NaN;
            return DVDItem.Price * 0.1;
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * 0.1;
        }
        public double Visit(Book BookItem)
        {
            return BookItem.Price * 0.1;
        }

    }
}
