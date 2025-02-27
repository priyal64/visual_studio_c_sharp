using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public Program p = new Program();
        //[TestMethod()]
        //public void AddTest()
        //{
        //    Assert.AreEqual(3, Program.Add(1, 2));
        //}

        [TestMethod()]
        public void AddNumbersTest_Positive_Numbers()
        {
            Assert.AreEqual(3,p.AddNumbers(1,2));
        }

        [TestMethod()]
        public void AddNumbersTest_Negative_Numbers()
        {
            Assert.AreEqual(3, p.AddNumbers(-1, -2));

        }
       
    }
}