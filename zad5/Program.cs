using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyVisitor NewBuyer = new BuyVisitor();
            Book newBook = new Book("Book", 5);
            DVD newdvd = new DVD("Test_dvd", DVDType.SOFTWARE, 10);
            Console.WriteLine(newBook.Accept(NewBuyer));
        }
    }
}
