using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Transactions 
    {
        private List<Operation> _transactions = new List<Operation>();

        public void logTransaction(string transactionDetails)
        {
            if (transactionDetails.Length > 0)
            {
                Operation operation = new Operation();
                operation.Details = transactionDetails;
                operation.createdAt = DateTime.Now;
                _transactions.Add(operation);
            }
        }
        
    }
}
