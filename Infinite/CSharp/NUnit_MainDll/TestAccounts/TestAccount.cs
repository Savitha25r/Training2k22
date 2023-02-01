using System;

using NUnit.Framework;
using NUnit_MainDll;

namespace TestAccounts
{
    [TestFixture]
    public class TestAccount
    {
        //Arrange the object
        Accounts acc= new Accounts("A12345");

      //  [SetUp]
      //public void TestSetup()
      //  {
      //      acc = new Accounts("A12345");
      //  }

        [Test]
        public void Deposit_method_should_showbalance1000()
        {
            //Ask for the method
            acc.Deposit(500);

            //asserting if the balance is 1000/-
            Assert.AreNotEqual(1500, acc.checkBalance());
        }

        public void TestWithdraw1()
        {
            acc.Withdraw(1200);
        }

        public void TestWithdraw2()
        {
            acc.Withdraw(200);
        }

        [Test]
        public void Should_Throw_exception()
        {
            Assert.Throws<Exception>(TestWithdraw1);
        }

        [Test]

        public void Should_Not_throwException()
        {
            Assert.DoesNotThrow(TestWithdraw2);
        }
    }
}
