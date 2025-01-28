using Microsoft.VisualStudio.TestTools.UnitTesting;
using rakos;
using System;

namespace rakostest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_1()
        {
            int numb = 0;
            int expected = 0;
            mult multiply = new mult();
            int resault = multiply.something(numb);
            Assert.AreEqual(expected,resault);
        }
        public void TestMethod1_2()
        {
            int numb = -1;
            int expected = -5;
            mult multiply = new mult();
            int resault = multiply.something(numb);
            Assert.AreEqual(expected, resault);
        }
        public void TestMethod1_3()
        {
            int numb = 1;
            int expected = 5;
            mult multiply = new mult();
            int resault = multiply.something(numb);
            Assert.AreEqual(expected, resault);
        }
        [TestMethod]
        public void TestMethod2_1()
        {
            int bignum = 7;
            int smallnum = 3;
            double expected = 3.3;
            mult plus = new mult();
            double resault = plus.plusmin(bignum,smallnum);
            Assert.AreEqual(expected, resault,0.3);
        }
        public void TestMethod2_2()
        {
            int bignum = 8;
            int smallnum = 5;
            double expected = 2.3;
            mult plus = new mult();
            double resault = plus.plusmin(bignum,smallnum);
            Assert.AreEqual(expected, resault,0.3);
        }
        public void TestMethod2_3()
        {
            int bignum = 9;
            int smallnum = 9;
            double expected = 2;
            mult plus = new mult();
            double resault = plus.plusmin(bignum, smallnum);
            Assert.AreEqual(expected, resault, 0.3);
        }
        public void TestMethod2_4()
        {
            int bignum = 4;
            int smallnum = 2;
            double expected = 3;
            mult plus = new mult();
            double resault = plus.plusmin(bignum, smallnum);
            Assert.AreEqual(expected, resault, 0.3);
        }
        [TestMethod]
        public void Testmethod3_1()
        {
            int numb = 0;
            int expected = 0;
            overridemult over = new overridemult();
            int resault = over.something(numb);
            Assert.AreEqual(expected, resault, 0.3);
        }
        public void Testmethod3_2()
        {
            int numb = -1;
            int expected = -7;
            overridemult over = new overridemult();
            int resault = over.something(numb);
            Assert.AreEqual(expected, resault, 0.3);
        }
        public void Testmethod3_3()
        {
            int numb = 1;
            int expected = 7;
            overridemult over = new overridemult();
            int resault = over.something(numb);
            Assert.AreEqual(expected, resault, 0.3);
        }
        [TestMethod]
        public void Testmethod4()
        {
            double numb1 = 1.1;
            double numb2 = 2.2;
            double numb3 = 3.3;
            double expected = 6.6;
            overridemult over = new overridemult();
            double resault = over.sum(numb1,numb2,numb3);
            Assert.AreEqual(expected, resault, 0.3);
        }
    }
}
