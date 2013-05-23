using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public class Account
    {
        public string AccountID { get; set; }
        public double Amount { get; set; }
        public double Interest { get; set; }

        public Account()
        {

        }

        public Account(string id, double amount, double interest)
        {
            AccountID = id;
            Amount = amount;
            Interest = interest;
        }
    }
}
