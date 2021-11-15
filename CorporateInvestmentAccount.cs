namespace BankApp
{
    class CorporateInvestmentAccount : InvestmentAccount
    {
        public CorporateInvestmentAccount()
        {
            
        }

        public CorporateInvestmentAccount(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
        }

    }
}
