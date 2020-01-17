using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountLibrary
{
    class UserInput
    {
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string Owner { get; set; }

        public void AddTransaction()
        {
            Console.WriteLine("Enter the Amount to Transact");
            this.Amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Transaction Note");
            this.Notes = Console.ReadLine();
        }
        public void CreateAccount()
        {
            Console.WriteLine("Enter the customers name:");
            this.Owner = Console.ReadLine();
            AddTransaction();

        }
    }
}
