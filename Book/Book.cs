using System;

namespace LibraryProject
{
    public class Book
    {

        private readonly string _title;
        private readonly string _author;

        public Book(string title, string author)
        {
            _title = title;
            _author = author;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }
    }
}