using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankApp.ViewModel;
using BankApp.Model;

namespace BankAppTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BankAppViewModel ba = new BankAppViewModel();
            Account ac1 = ba.Accounts[0];
            Account ac2 = new Account("Account 1", 500.00, 0.013);
            Assert.IsNotNull(ac1.AccountID);
        }

        //[TestMethod]
        //public void TestMethood2()
        //{
        //    BankAppViewModel ba = new BankAppViewModel();
        //    ba.Initialize();
        //    Account s = ba.input();
        //    Account d = new Account("Account 1", 500.00, 0.013);
        //    Assert.AreEqual(s.AccountID, d.AccountID);
        //    Assert.AreEqual(s.Amount, d.Amount);
        //    Assert.AreEqual(s.Interest, d.Interest);
        //}

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
