using System;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            RentVisitor RentVisiotr1 = new RentVisitor();
            Cart cart = new Cart();
            cart.AddItem(new Book("test knjiga", 20));
            cart.AddItem(new DVD("testDvd",DVDType.SOFTWARE,30));

            Console.WriteLine(cart.Accept(RentVisiotr1));
        }
    }
}
