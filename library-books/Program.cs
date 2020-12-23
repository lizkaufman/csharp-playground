using System;

namespace library_books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter and the Sorceror's Stone", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings: The Fellowship of the Ring", "JRR Tolkein", 600);

            book2.title = "Lord of the Rings: The Two Towers";

            Console.WriteLine($"My books are {book1.title} and {book2.title}.");
        }
    }
}
