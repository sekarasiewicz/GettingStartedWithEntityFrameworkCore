using static System.Console;
using System.Collections.Generic;

namespace GettingStartedWithEntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EFCoreDemoContext())
            {
                foreach(var book in context.Books)
                {
                    WriteLine();
                    WriteLine(book.Title);
                }
            }
        }
    }
}