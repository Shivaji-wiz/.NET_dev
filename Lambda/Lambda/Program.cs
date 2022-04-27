using System;

namespace LamdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
        }
    }
}