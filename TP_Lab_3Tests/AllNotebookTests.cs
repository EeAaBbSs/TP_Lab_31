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
            int noP = 2;
            Notebook notebook = new Notebook(noP);
            string expected = "Number of pages: 2\nText of the 1 page\nText of the 2 page\n";
            string actual = notebook.Info();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestCoverNotebook()
        {
            int noP = 3; string covMaterial = "carton";
            CoveredNotebook notebook = new CoveredNotebook(noP, covMaterial);
            string expected = "Cover material: carton\nNumber of pages: 3\nText of the 1 page\nText of the 2 page\nText of the 3 page\n";
            string actual = notebook.Info();
            Assert.AreEqual(expected, actual);
            //Проверка коммита на гитхаб
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NotebookExceptionTest1()
        {
            Notebook notebook = new Notebook(0);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NotebookExceptionTest2()
        {
            Notebook notebook = new Notebook(-1);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CoveredNotebookExceptionTest1()
        {
            CoveredNotebook notebook = new CoveredNotebook(2, "");
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CoveredNotebookExceptionTest2()
        {
            CoveredNotebook notebook = new CoveredNotebook(2, null);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CoveredNotebookExceptionTest3()
        {
            CoveredNotebook notebook = new CoveredNotebook(2, "\n    \t \r ");
        }
    }
}