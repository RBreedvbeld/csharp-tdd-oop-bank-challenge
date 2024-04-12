using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Boolean.CSharp.Main
{
    internal interface IAccount
    {
        // bool Deposit(float amount, EAccountTypes accountType);
        bool Withdraw(float amount, EAccountTypes accountType, float balance);
    }
}
