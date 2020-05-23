using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects

{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Things Fall Apart";
            book1.author = "Chinua Achebe";
            book1.pages = 420;

            Book book2 = new Book();
            book2.title = "Angels And Demon";
            book2.author = "Dan Brown";
            book2.pages = 840;

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
