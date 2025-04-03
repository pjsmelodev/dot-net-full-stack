using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal interface IManageBank
    {
        void OpenAccount();
        void CloseAccount();
    }

    internal interface IBankAccount
    {
        // Todos os métodos de um Interface são públicos e abstratos por defeito
        void Deposit();
        void Withdraw();
        void Balance();
    }

    public class SavingAcc : IBankAccount, IManageBank
    {
        public void Balance()
        {
            Console.WriteLine("Saving Account Balance");
        }

        public void CloseAccount()
        {
            Console.WriteLine("Closing Saving Account.");
        }

        public void Deposit()
        {
            Console.WriteLine("Saving Account Deposit");
        }

        public void OpenAccount()
        {
            Console.WriteLine("Opening Saving Account.");
        }

        public void Withdraw()
        {
            Console.WriteLine("Saving Account Withdraw");
        }
    }
}
