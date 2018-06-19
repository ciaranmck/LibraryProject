using System;

namespace LibraryProject
{
    public class Book
    {

        private readonly string _title;
        private readonly string _author;
        private readonly string _genre;

        public Book(string title, string author, string genre)
        {
            _title = title;
            _author = author;
            _genre = genre;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public string GetGenre()
        {
            return _genre;
        }
    }
}