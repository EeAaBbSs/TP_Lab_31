using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Lab_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3.Tests
{
    [TestClass()]
    public class AllNotebookTests
    {
        [TestMethod()]
        public void TestNotebook()
        {
            Notebook notebook = new Notebook();
            string expected = "Number of pages 5\nText of the first page.\nText of the second page.\nText of the third page.\nText of the fourth page.\nText of the fifth page.\n";
            string actual = notebook.Info();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestCoverNotebook()
        {
            CoveredNotebook notebook = new CoveredNotebook();
            string expected = "Type of cover: Hard\nNumber of pages 5\nText of the first page.\nText of the second page.\nText of the third page.\nText of the fourth page.\nText of the fifth page.\n";
            string actual = notebook.Info();
            Assert.AreEqual(expected, actual);
            //Проверка коммита на гитхаб
        }
    }
}