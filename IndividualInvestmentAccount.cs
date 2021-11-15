using System;

namespace BankApp
{
    class IndividualInvestmentAccount : InvestmentAccount
    {
        private const double MAXIMUM_WITHDRAWAL_AMOUNT = 500;

        public IndividualInvestmentAccount()
        {

        }

        public IndividualInvestmentAccount(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
        }
        public override void Withdraw(double amount)
        {
            Console.WriteLine($"Your starting balance is: {Balance}\n" +
                $"Initiating Withdrawal of {amount}");
            if (amount > MAXIMUM_WITHDRAWAL_AMOUNT)
            {
                Console.WriteLine($"Amount {amount} exceeds {MAXIMUM_WITHDRAWAL_AMOUNT}. Withdrawal rejected");
                return;
            }
            base.Withdraw(amount);
        }
    }
}
