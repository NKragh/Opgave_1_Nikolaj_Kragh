using System;
using System.Diagnostics.SymbolStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave_1_Nikolaj_Kragh;

namespace BogTest
{
    [TestClass]
    public class UnitTest1
    {
        Book b1 = new Book();
        Book b2 = new Book("Bog", "Forfatter", 10, "kduitgmvlsigt");

        //Valid tests
        [TestMethod]
        public void TitleTest()
        {
            b1.Titel = "XX";
            Assert.AreEqual(b1.Titel, "XX");
        }
        [TestMethod]
        public void ForfatterTest()
        {
            b1.Forfatter = "Johan Nilesen";
            Assert.AreEqual(b1.Forfatter, "Johan Nilesen");
        }

        [TestMethod]
        public void PageTest()
        {
            b1.Sidetal = 10;
            Assert.AreEqual(b1.Sidetal, 10);
            b1.Sidetal = 1000;
            Assert.AreEqual(b1.Sidetal, 1000);
        }

        [TestMethod]
        public void ISBNTest()
        {
            b1.Isbn13 = "0294850103859";
            Assert.AreEqual(b1.Isbn13, "0294850103859");

        }

        //Exception tests
        [TestMethod]
        [ExpectedException(typeof(TitleTooShortException))]
        public void TestTitleException()
        {
            b1.Titel = "x";
        }

        [TestMethod]
        [ExpectedException(typeof(TooManyPagesException))]
        public void TestPageMinException()
        {
            b1.Sidetal = 9;
        }
        [TestMethod]
        [ExpectedException(typeof(TooManyPagesException))]
        public void TestPageMaxException()
        {
            b1.Sidetal = 1001;
        }

        [TestMethod]
        [ExpectedException(typeof(ISBN13NotValidException))]
        public void TestISBNException()
        {
            b1.Isbn13 = "123";
        }
    }
}
