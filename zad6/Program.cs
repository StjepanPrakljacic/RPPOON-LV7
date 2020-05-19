using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            RentVisitor Rentvisitor1 = new RentVisitor();
            Book newBook = new Book("Test_Book", 60);
            DVD newDvd = new DVD("Test_Dvd", DVDType.SOFTWARE, 10);
            Console.WriteLine(newBook.Accept(Rentvisitor1));
            Console.WriteLine(newDvd.Accept(Rentvisitor1));
        }
    }
}
