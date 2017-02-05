using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_PackLibrary
{
    public class BankAccount
    {
        public string AccountName;
        public decimal Balance;
        public static decimal InterestRate;

        public void Withdraw(decimal amount)
        {
            if ((Balance - amount) < 0M)
            {
                throw new BadImageFormatException("Balance cannot be less than zero!");
            } else
            {
                Balance -= amount;
            }
        }
    }
}
