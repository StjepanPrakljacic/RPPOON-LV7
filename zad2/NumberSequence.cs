using System;
using System.Collections.Generic;
using System.Text;

namespace zad2
{
    class NumberSequence
    {
        private double[] sequence;
        private int sequenceSize;
        private SearchStrategy searchStrategy;
        public NumberSequence(int sequenceSize)
        {
            this.sequenceSize = sequenceSize;
            this.sequence = new double[sequenceSize];
        }
        public NumberSequence(double[] array) : this(array.Length)
        {
            array.CopyTo(this.sequence, 0);
        }
        public void InsertAt(int index, double value)
        {
            this.sequence[index] = value;
        }
        public void SetSearchStrategy(SearchStrategy strategy)
        {
            this.searchStrategy = strategy;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (double element in this.sequence)
            {
                builder.Append(element).Append(Environment.NewLine);
            }
            return builder.ToString();
        }
        public bool Search(double searchedItem) { return this.searchStrategy.Search(sequence, searchedItem); }
    }
}
