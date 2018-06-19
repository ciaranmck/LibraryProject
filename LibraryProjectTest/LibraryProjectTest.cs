using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryProject;
using System.Linq;

namespace LibraryProjectTest
{
    [TestClass]
    public class LibraryProjectTest
    {
        Library library;
        Book book;
        Book book2;
        ArrayList bookArray;
        Borrower borrower;
        ArrayList backpack;

        [TestInitialize]
        public void Initialize()
        {
            book = new Book("The Joy of Sex", "Alex Comfort");
            book2 = new Book("They Joy of Sex", "Alex Comforter");
            bookArray = new ArrayList();
            bookArray.Add(book);
            library = new Library(bookArray, "Ciaran and Marky's Wonder Library", 10);
            backpack = new ArrayList();
            borrower = new Borrower("Ciaran", backpack);
        }

        [TestMethod]
        public void TestLibraryHasName()
        {
            Assert.AreEqual("Ciaran and Marky's Wonder Library", library.GetName());
        }
        
        [TestMethod]
        public void TestLibraryHasCollection()
        {
            Assert.AreEqual(1, library.CountCollection());
        }

        [TestMethod]
        public void TestCanAddBookToLibrary()
        {
            library.AddBook(book2);

            Assert.AreEqual(2, library.CountCollection());
        }

        [TestMethod]
        public void TestLibraryHasCapacity()
        {
            Assert.AreEqual(10, library.GetCapacity());
        }

        [TestMethod]
        public void TestLibraryIsAtCapacity()
        {
            Assert.AreEqual(false, library.IsAtCapacity());
            foreach(int num in Enumerable.Range(1, 9))
            {
                library.AddBook(new Book("The Joy of Sex", "Alex Comfort")); 
            }
            Assert.AreEqual(true, library.IsAtCapacity());
        }

        [TestMethod]
        public void TestCannotAddBookIfAtCapacity()
        {
            foreach (int num in Enumerable.Range(1, 9))
            {
                library.AddBook(new Book("The Joy of Sex", "Alex Comfort"));
            }
            Assert.AreEqual(true, library.IsAtCapacity());
            library.AddBook(book2);
            Assert.AreEqual(10, library.CountCollection());
            Assert.AreEqual("Go fuck yourself! We got enough books!", library.AddBook(book2));
        }

        [TestMethod]
        public void TestLibraryRemovesBook()
        {
            borrower.BorrowBook(library.RemoveBook(book));

            Assert.AreEqual(1, borrower.CountBooks());
            Assert.AreEqual(0, library.CountCollection());
        }
    }
}
