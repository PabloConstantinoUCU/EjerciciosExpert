using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelve shelve1 = new Shelve("A", 1000, 1);
            Shelve shelve2 = new Shelve("b", 500, 2);
            shelve1.ShelveBook(book2);
            shelve1.ShelveBook(book1);
            shelve1.PrintBooks();

        }
    }
}