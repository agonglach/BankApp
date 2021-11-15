using System;

namespace BankApp
{
    abstract class Account : IAccount
    {
        public string Owner { get; set; }
        public double Balance { get; set; }

        public virtual void Deposit(double amount)
        {
            Console.WriteLine($"Your starting balance is: {Balance}\n" +
                $"Initiating Deposit of {amount}");
            Balance += amount;
            Console.WriteLine($"Your new balance is: {Balance}");
        }
        public virtual void Withdraw(double amount)
        {
            Console.WriteLine($"Your starting balance is: {Balance}\n" +
                $"Initiating Withdrawal of {amount}");
            Balance -= amount;
            Console.WriteLine($"Your new balance is: {Balance}");
        }
        public virtual void Transfer(double amount, IAccount transferToAccount)
        {
            Console.WriteLine($"Your starting balance is: {Balance}\n" +
                $"Initiating Transfer of {amount} to Account Owner: {transferToAccount.Owner}");
            Balance -= amount;
            transferToAccount.Balance += amount;
            Console.WriteLine($"Your new balance is: {Balance}");
        }
    }
}
