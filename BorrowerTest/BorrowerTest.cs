using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryProject
{
    [TestClass]
    public class BorrowerTest
    {
        ArrayList backpack;
        Borrower borrower;

        [TestInitialize]
        public void Initialize()
        {
            backpack = new ArrayList();
            borrower = new Borrower("Ciaran", backpack);
        }

        [TestMethod]
        public void TestBorrowerHasName()
        {
            Assert.AreEqual("Ciaran", borrower.GetName());
        }

        [TestMethod]
        public void TestBorrowerHasBook()
        {
            Book book = new Book("The Joy of Sex", "Alex Comfort", "Porn");
            borrower.BorrowBook(book);
            Assert.AreEqual(1, borrower.CountBooks());
        }            
    }
}
