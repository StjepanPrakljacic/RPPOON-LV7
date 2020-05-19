using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 57, -652, 1100, 874, 563, 1, 15, 19, 27, -68, 241 };
            NumberSequence sequence = new NumberSequence(array);
            LinearSearch linearSearch = new LinearSearch();
            sequence.SetSearchStrategy(linearSearch);
            Console.WriteLine(sequence.Search(999));

            
        }
    }
}
