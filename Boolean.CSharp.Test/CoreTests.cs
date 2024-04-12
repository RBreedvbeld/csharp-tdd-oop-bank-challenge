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
            _accounts = new Account(accountNumber, userName, EAccountTypes.Checking);
        }

        [Test]
        public void TestAddSavingsAccountToList()
        {
            _accounts = new Account(accountNumber, userName, EAccountTypes.Checking);
            bool addAccount = _accounts.AddAccount("111", "Rose Breedveld", EAccountTypes.Checking);
            Assert.That(addAccount, Is.True);
        }

        [Test]
        public void TestDepositCheckingAccount()
        {
            bool checkingDeposit = _accounts.Deposit(100, EAccountTypes.Checking, 1000);
            Assert.That(checkingDeposit, Is.True);
        }

        [Test]
        public void TestWitdrawCheckingAccount()
        {
            //_accounts.Withdraw(100, EAccountTypes.Checking, 1000);
            bool checkingWithdraw = _accounts.Withdraw(100, EAccountTypes.Checking, 1000);
            Assert.That(checkingWithdraw, Is.True);
        }

        [Test]
        public void TestWitdrawSavingAccount()
        {
            //_accounts.Withdraw(100, EAccountTypes.Checking, 1000);
            bool savingWithdraw = _accounts.Withdraw(100, EAccountTypes.Saving, 1000);
            Assert.That(savingWithdraw, Is.True);
        }

        // TODO check the logic for testcase [2] and testcase [6]
        [TestCase(100, EAccountTypes.Saving, 1000, true)]
        [TestCase(1000, EAccountTypes.Saving, 1000, true)]
        [TestCase(1000, EAccountTypes.Saving, 900, false)]
        [TestCase(0, EAccountTypes.Saving, 1000, false)]
        [TestCase(100, EAccountTypes.Checking, 1000, true)]
        [TestCase(1000, EAccountTypes.Checking, 1000, true)]
        [TestCase(1000, EAccountTypes.Checking, 900, false)]
        [TestCase(0, EAccountTypes.Checking, 1000, false)]
        public void TestWithdraw(float witdraw, EAccountTypes accountType, float balance, bool expectedOutcome)
        {
            bool witdrawTestCases = _accounts.Withdraw(witdraw, accountType, balance);
            //Assert
            Assert.That(witdrawTestCases, Is.EqualTo(expectedOutcome));
        }

        // TODO Write a test to check if transaction is added to Transaction List

    }
}