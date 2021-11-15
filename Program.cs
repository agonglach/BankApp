using System;
using System.Collections.Generic;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IBank testBank = new Bank("Sunrise Banking", null);

            IAccount testCheckingAccount = new CheckingAccount("John Smith", 3000);
            IAccount testIndividualInvestmentAccount = new IndividualInvestmentAccount("Rob Johnson", 1400);
            IAccount testCorporateInvestmentAccount = new CorporateInvestmentAccount("ACME Corp", 3000000);

            testBank.Accounts = new List<IAccount>();
            testBank.Accounts.Add(testCheckingAccount);
            testBank.Accounts.Add(testIndividualInvestmentAccount);
            testBank.Accounts.Add(testCorporateInvestmentAccount);

            IAccount testTransferAccount = new CorporateInvestmentAccount("ABC Inc", 0);

            foreach (IAccount account in testBank.Accounts)
            {
                Console.WriteLine($"Account of type: {account.GetType()}\n" +
                    $"Account Owner: {account.Owner}");
                account.Deposit(3500);
                account.Withdraw(2000);
                account.Transfer(500, testTransferAccount);
                Console.WriteLine($"Transfer account balance: {testTransferAccount.Balance}\n");
            }

        }
    }
}
