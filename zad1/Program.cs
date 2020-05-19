using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrey = new double[] {57, -652, 1100, 874, 563, -1, 15, 19, 27, -68, 241};
            NumberSequence sequence = new NumberSequence(arrey);
            BubbleSort BubbleSorter = new BubbleSort();
            sequence.SetSortStrategy(BubbleSorter);
            Console.WriteLine("Arrey:\n" + sequence.ToString());
            sequence.Sort();
            Console.WriteLine("Sorted Arrey:\n" + sequence.ToString());
        }
    }
}
