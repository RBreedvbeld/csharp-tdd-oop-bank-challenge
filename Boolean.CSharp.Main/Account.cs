using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Account : IAccount
    {
        private Dictionary<string, Account> _accounts = new Dictionary<string, Account>();
        public Dictionary<string, Account> accounts => _accounts;

        private float _balance = 1000;

        // private string _accountNumber;

        // Getters
        // public string AccountNumber => _accountNumber;
        public string AccountNumber { get; }
        public string UserName { get; }
        public EAccountTypes EAccountTypes { get; set; }
        public EBankServices BankServices { get; set; }
        public float Balance => _balance;


        public Account(string accountNumber, string usersName)
        {
            //_accounts.Add(new SavingsAccount());
            //_accounts.Add(new CheckingAccount());
            this.AccountNumber = accountNumber;
            this.UserName = usersName;
        }

        public bool AddAccount(string accountNumber, string username)
        {
            Account newAccount = new Account(accountNumber, username); 
            accounts.Add(accountNumber, newAccount);
            return true;
        }

        public float GetBalance()
        {
            return Balance;
        }

        public bool Withdraw(float amount, EAccountTypes accountType, float balance)
        {
            if(accountType == EAccountTypes.Checking || accountType == EAccountTypes.Saving)
            {
                if (amount > 0 && (balance - amount) >= 0)
                {
                    Console.WriteLine($"Withdrawing {amount} from {accountType} account:");
                    balance -= amount;
                    // update the balance after withdrawing
                    _balance = balance;
                    Console.WriteLine($"Your new balance after the witdraw is $ {_balance}.");
                    return true;
                } else
                {
                    Console.WriteLine("Not enough balance or amount is bigger than balance");
                    return false;
                }

            } 
            else 
            {
                Console.WriteLine("Invalid Account Type.");
            }
            return false;
        }



      
    }
}
