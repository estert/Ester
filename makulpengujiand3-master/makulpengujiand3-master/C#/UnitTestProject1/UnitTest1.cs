using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow kal = new MainWindow();
            double hasil = kal.plus(2, 3);
            double a = 5;
            Assert.AreEqual(a, hasil, "salah");
        }

        [TestMethod]
        public void TestMethod2()
        {
            MainWindow kal = new MainWindow();
            double hasil = kal.min(3, 2);
            double a = 1;
            Assert.AreEqual(a, hasil, "salah");
        }

        [TestMethod]
        public void TestMethod3()
        {
            MainWindow kal = new MainWindow();
            double hasil = kal.div(6, 3);
            double a = 2;
            Assert.AreEqual(a, hasil, "salah");
        }

        [TestMethod]
        public void TestMethod4()
        {
            MainWindow kal = new MainWindow();
            double hasil = kal.kali(2, 3);
            double a = 6;
            Assert.AreEqual(a, hasil, "salah");
        }
    }
}
