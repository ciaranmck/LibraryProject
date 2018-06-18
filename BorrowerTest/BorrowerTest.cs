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
        public void initialize()
        {
            backpack = new ArrayList();
            borrower = new Borrower("Ciaran", backpack);
        }

        [TestMethod]
        public void BorrowerHasName()
        {
            Assert.AreEqual("Ciaran", borrower.GetName());
        }

        [TestMethod]
        public void BorrowerHasBook()
        {
            Book book = new Book("The Joy of Sex", "Alex Comfort");
            backpack.Add(book);
            Assert.AreEqual(1, borrower.CountBooks());
        }
    }
}
