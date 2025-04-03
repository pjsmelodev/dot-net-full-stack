using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public abstract class BankAccount
    {

        public abstract void Deposit();

        public abstract void Withdraw();

        public abstract void Balance();
    }

    public class SavingsAccount : BankAccount
    {
        // May contain nono-abstract methods
        public void GetMessage()
        {
            Console.WriteLine("Welcome to ABC Bank.");
        }

        public override void Balance()
        {
            Console.WriteLine("Balance and Saving Account.");
        }

        public override void Deposit()
        {
            Console.WriteLine("Deposit and Saving Account.");
        }

        public override void Withdraw()
        {
            Console.WriteLine("Withdrawal from Saving Account.");
        }
    }
}
