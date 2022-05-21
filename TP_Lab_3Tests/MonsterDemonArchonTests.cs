using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Lab_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3.Tests
{
    [TestClass()]
    public class MonsterDemonArchonTests
    {
        [TestMethod()]
        public void MonsterTest()
        {
            Monster testMonster = new Monster("enemy");
            string expected = "Type: enemy";
            string actual = testMonster.Info();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DemonTest()
        {
            Demon testMonster = new Demon("enemy", "feather", "bone");
            string expected = "Type: enemy, has a following characteristics:\nMaterial of wings: feather\nMaterial of horns: bone";
            string actual = testMonster.Info();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ArchonTest()
        {
            Archon testMonster = new Archon("enemy", "feather", "bone", 300);
            string expected = "Type: enemy, has a following characteristics:\nMaterial of wings: feather\nMaterial of horns: bone\nIQ: 300";
            string actual = testMonster.Info();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void MonsterNotebookExceptionTest()
        {
            Monster monster = new Monster("zxc");
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DemonNotebookExceptionTest1()
        {
            Demon demon = new Demon("Enemy", " ", "bone");
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DemonNotebookExceptionTest2()
        {
            Demon demon = new Demon("Ally", "papper", "");
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ArchonExceptionTest()
        {
            Archon demon = new Archon("Enemy", "feather", "steel", 299);
        }
    }
}