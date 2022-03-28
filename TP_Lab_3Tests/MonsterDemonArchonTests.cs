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
            Monster testMonster = new Monster();
            string expected = "Type: Enemy";
            string actual = testMonster.Info();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DemonTest()
        {
            Demon testMonster = new Demon();
            string expected = "Type: Enemy, has a following characteristics: Wings, Horns";
            string actual = testMonster.Info();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ArchonTest()
        {
            Archon testMonster = new Archon();
            string expected = "Type: Enemy, has a following characteristics: Wings, Horns, High intellegence";
            string actual = testMonster.Info();
            Assert.AreEqual(expected, actual);
        }
    }
}