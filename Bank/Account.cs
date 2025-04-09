using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseClassesOOP01.Bank
{
    internal class Account
    {
        public string accountName;
        public double amount;

        public double Withdrawal(double withdrawAmount)
        {
            
            return amount = amount - withdrawAmount;
        }

        public double Deposit(double depositAmount)
        {
            return amount = amount + depositAmount;
        }



    }
}
