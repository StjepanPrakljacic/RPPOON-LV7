using System;
using System.Collections.Generic;
using System.Text;

namespace zad2
{
    class LinearSearch : SearchStrategy
    {
        public override bool Search(double[] array,double value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return true;
            }
            return false;
        }

    }
}
