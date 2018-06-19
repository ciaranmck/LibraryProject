using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryProject;

namespace BookTest
{
    [TestClass]
    public class BookTest
    {
        Book book;

        [TestInitialize]
        public void Initialize()
        {
            book = new Book("The Joy of Sex", "Alex Comfort", "Porn");
        }

        [TestMethod]
        public void TestBookHasTitle()
        {
            Assert.AreEqual("The Joy of Sex", book.GetTitle());
        }

        [TestMethod]
        public void TestBookHasGenre()
        {
            Assert.AreEqual("Porn", book.GetGenre());
        }
    }
}
