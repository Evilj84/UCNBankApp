using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankApp.ViewModel;
using BankApp.Model;
using System.Collections.ObjectModel;

namespace BankAppTestProject
{
    [TestClass]
    public class UnitTest1
    {
        #region Black Box Tests

        [TestMethod]
        public void BlackWithdrawAmountToZero()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 500.00, 0.013);
            ba.WithdrawAmount(500);
            double expected = 500 - 500;
            double actual = ba.SelectedAccount.Amount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BlackWithdrawAmountOverBalance()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 500.00, 0.013);

            try
            {
                ba.WithdrawAmount(501);
                Assert.Fail("It is supposed to fail, because you can not withdraw more than is in the account");
            }
            catch (InvalidWithdrawException)
            {
            }
        }

        [TestMethod]
        public void BlackWithdrawAmountMinus()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 500.00, 0.013);

            try
            {
                ba.WithdrawAmount(-500);
                Assert.Fail("It is supposed to fail, because you cant withdraw a minus amount");
            }
            catch (InvalidWithdrawException)
            {
            }
        }

        [TestMethod]
        public void BlackWithdrawAmountZero()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 500.00, 0.013);

            try
            {
                ba.WithdrawAmount(0);
                Assert.Fail("It is supposed to fail, because you cant withdraw 0");
            }
            catch (InvalidWithdrawException)
            {
            }
        }

        [TestMethod]
        public void BlackInterestAdd()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 500.00, 0.013);
            ba.AddInterest(51);
            double expected = 500 + (500 * 0.013);
            double actual = ba.SelectedAccount.Amount;
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region White Box Tests

        [TestMethod]
        public void WhiteWithdrawMoreThanThousand()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 1500.0, 0.013);
            try
            {
                ba.WithdrawAmount(1001.00);
                Assert.Fail("It is supposed to fail, because you cant withdraw more than 1000.00");
            }
            catch (InvalidWithdrawException)
            {
            }
        }

        [TestMethod]
        public void WhiteDepositMoreThanTenThousand()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 1500.0, 0.013);
            try
            {
                ba.DepositAmount(10000.01);
                Assert.Fail("It is supposed to fail, because you cant deposit more than 10000.00");
            }
            catch (InvalidDepositException)
            {
            }
        }

        [TestMethod]
        public void WhiteDepositLessThanZero()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 1500.0, 0.013);
            try
            {
                ba.DepositAmount(-1.00);
                Assert.Fail("It is supposed to fail, because you cant deposit less than zero");
            }
            catch (InvalidDepositException)
            {
            }
        }

        [TestMethod]
        public void WhiteDepositZero()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 1500.0, 0.013);
            try
            {
                ba.DepositAmount(0.00);
                Assert.Fail("It is supposed to fail, because you cant deposit 0.00");
            }
            catch (InvalidDepositException)
            {
            }
        }

        [TestMethod]
        public void WhiteDepositAmount()
        {
            BankAppViewModel ba = new BankAppViewModel();
            ba.SelectedAccount = new Account("Account 1", 1500.0, 0.013);
            ba.DepositAmount(500);
            double expected = 1500.00 + 500.00;
            double actual = ba.SelectedAccount.Amount;
            Assert.AreEqual(expected, actual);
        }

        #endregion

        [TestMethod]
        public void UselessTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
