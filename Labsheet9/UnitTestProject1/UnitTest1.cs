using System;
using Labsheet9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeposit()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            decimal ExpectedBalance = 200m;

            //Act
            acc1.Deposit(200m);

            //Assert
            Assert.AreEqual(ExpectedBalance, acc1.Balance);
        }


        [TestMethod]
        public void TestMultiDeposit()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            decimal ExpectedBalance = 200m;

            //Act
            acc1.Deposit(100m);
            acc1.Deposit(60m);
            acc1.Deposit(40m);

            //Assert
            Assert.AreEqual(ExpectedBalance, acc1.Balance);
        }

        [TestMethod]
        public void TestNewAccountHasZerobalance()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            decimal ExpectedBalance = 0m;

            //Act
            

            //Assert
            Assert.AreEqual(ExpectedBalance, acc1.Balance);
        }

        [TestMethod]
        public void TestWithDrawStufficientFunds()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            acc1.Deposit(200m);
            decimal ExpectedBalance = 100m;

            //Act
            acc1.WithDraw(100m);

            //Assert
            Assert.AreEqual(ExpectedBalance, acc1.Balance);
        }

        [TestMethod]
        public void Test_Insufficient_Funds()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            acc1.Deposit(100m);
            decimal ExpectedBalance = 100m;

            //Act
            acc1.WithDraw(200m);

            //Assert
            Assert.AreEqual(ExpectedBalance, acc1.Balance);
        }

        [TestMethod]
        public void Test_Insufficient_Funds_With_OverDraft()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            acc1.OverDraftLimit = 200m;
            decimal ExpectedBalance = -100m;

            //Act
            acc1.WithDraw(100m);

            //Assert
            Assert.AreEqual(ExpectedBalance, acc1.Balance);
        }

        [TestMethod]
        public void Test_Insufficient_FundsWith_OverDrafts()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            acc1.Deposit(200m);
            decimal ExpectedBalance = 0m;

            //Act
            acc1.WithDraw(300m);

            //Assert
            Assert.AreEqual(ExpectedBalance, acc1.Balance);
        }
    }
}
