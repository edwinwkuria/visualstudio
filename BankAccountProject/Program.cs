using BankAccountLibrary;
using System;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var ThisInput = new UserInput();
            ThisInput.CreateAccount();
            var account = new BankAccount(ThisInput.Owner, ThisInput.Amount);
            Console.WriteLine("Account {0} was created for {1} with {2}", account.Number, account.Owner, account.Balance);
            Console.WriteLine("Enter 0 to add a transaction or 1 to exit:");
            int input = Convert.ToInt16(Console.ReadLine());
            while (input == 0)
            {
                
                ThisInput.AddTransaction();
                Console.WriteLine("Enter 0 for deposit and 1 for withdrawal");
                int TransactionType = Convert.ToInt16(Console.ReadLine());
                if(TransactionType == 0)
                {
                    account.MakeDeposit(ThisInput.Amount, DateTime.Now, ThisInput.Notes);
                }
                else if (TransactionType == 1)
                {
                    account.MakeWithdrawal(ThisInput.Amount, DateTime.Now, ThisInput.Notes);
                }
                else
                {
                    Console.WriteLine("Invalid Transaction Type Transaction has been aborted");
                }
                Console.WriteLine("Enter 0 to add a transaction or 1 to exit:");
                input = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
