using System;

namespace library_books
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            //can have more than one constructor - this one would let me create a book w/ just new Book() with no args handed in 
        }

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
