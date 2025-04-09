using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcerciseClassesOOP01.Bank;



namespace ExcerciseClassesOOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account heikkisAccount = new Account();
            heikkisAccount.accountName = "Heikki's Account";
            heikkisAccount.amount = 100.0;

            Account heikkisSwissAccount = new Account();
            heikkisSwissAccount.accountName = "Heikki's Swiss Account";
            heikkisSwissAccount.amount = 100;

            Console.WriteLine(heikkisAccount.accountName);
            Console.WriteLine(heikkisAccount.amount);

            heikkisAccount.Withdrawal(20);

            Console.WriteLine(heikkisAccount.amount);

            Console.WriteLine($"Account balance after withdraw is  {heikkisAccount.amount}");

            heikkisAccount.Deposit(100);

            Console.WriteLine($"Account balance after deposit is {heikkisAccount.amount}");

            heikkisSwissAccount.Deposit(300);

            Console.WriteLine($"Heikkis Swiss account balance is now {heikkisSwissAccount.amount}");


        }
    }
}
