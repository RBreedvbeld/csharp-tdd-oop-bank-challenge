using Boolean.CSharp.Main;
using NuGet.Frameworks;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Account _accounts;
        private string accountNumber;
        private string userName;
        private float balance;

        [SetUp]
        public void SetUp() 
        {
            _accounts = new Account(accountNumber, userName);
        }

        [Test]
        public void TestAddSavingsAccountToList()
        {
            bool addAccount = _accounts.AddAccount("111", "Rose Breedveld");
            Assert.That(addAccount, Is.True);
        }

        [Test]
        public void TestWitdrawCheckingAccount()
        {
            //_accounts.Withdraw(100, EAccountTypes.Checking, 1000);
            bool CheckingWitdraw = _accounts.Withdraw(100, EAccountTypes.Checking, 1000);
            Assert.That(CheckingWitdraw, Is.True);
        }

        // TODO Write a test to check if transaction is added to Transaction List
            
    }
}