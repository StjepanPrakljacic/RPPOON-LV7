using System;
using System.Collections.Generic;
using System.Text;

namespace zad7
{
    class RentVisitor : IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
                return DVDItem.Price;
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
